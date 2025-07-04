using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using iText.Signatures;
using OtpNet;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;

namespace SignalPdf
{
    class ServerSignature : IExternalSignature
    {
        #region Member Variables
        private string _sourcePlainPdf;
        private string _authenticationToken;
        private string _qscdServerBaseAddress;
        private string _certificateAlias;
        private string _seed;
        private string _secret;
        private string _hashAlgorithmOID;
        #endregion // Member Variables

        #region Ctors
        public ServerSignature(string sourcePlainPdf, string authenticationToken, string qscdServerBaseAddress,
            string certificateAlias, string seed, string secret, string hashAlgorithmOID)
        {
            _sourcePlainPdf = sourcePlainPdf;
            _authenticationToken = authenticationToken;
            _qscdServerBaseAddress = qscdServerBaseAddress;
            _certificateAlias = certificateAlias;
            _seed = seed;
            _secret = secret;
            _hashAlgorithmOID = hashAlgorithmOID;
        }
        #endregion // Ctors

        #region Overridables
        public String GetHashAlgorithm()
        {
            return DigestAlgorithms.SHA256;
        }

        public String GetEncryptionAlgorithm()
        {
            return "RSA";
        }

        public byte[] Sign(byte[] message)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string digest;
                using (SHA256Managed sha = new SHA256Managed())
                {
                    byte[] hash = sha.ComputeHash(message);

                    digest = Convert.ToBase64String(hash);
                }

                List<JObject> docsToSign = new List<JObject>();

                dynamic docToSignInfo = new JObject();
                docToSignInfo.docAlias = System.IO.Path.GetFileName(_sourcePlainPdf);
                docToSignInfo.hashAlg = _hashAlgorithmOID;
                docToSignInfo.sigType = 1;
                docToSignInfo.hashToSign_64 = digest;
                docsToSign.Add(docToSignInfo);

                dynamic jsonSigCompleteTOTPRequest = new JObject();
                jsonSigCompleteTOTPRequest.certAlias = _certificateAlias;
                jsonSigCompleteTOTPRequest["docsToSign"] = JToken.FromObject(docsToSign);
                jsonSigCompleteTOTPRequest.sigReqDescr = Guid.NewGuid().ToString();
                jsonSigCompleteTOTPRequest.totpID = _seed;

                var totp = new Totp(Base32Encoding.ToBytes(_secret));
                jsonSigCompleteTOTPRequest.totpValue = totp.ComputeTotp(DateTime.UtcNow.AddSeconds(-5));

                byte[] signedHash = null;

                using (var handler = new HttpClientHandler())
                {
                    //create an HttpClient and pass a handler to it
                    using (var httpClient = new HttpClient(handler))
                    {
                        httpClient.DefaultRequestHeaders.Clear();
                        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authenticationToken);

                        HttpResponseMessage responseMessage = httpClient.PostAsync(new Uri(_qscdServerBaseAddress + "/totp/sigCompleteTOTP"),
                            new StringContent(jsonSigCompleteTOTPRequest.ToString(), UnicodeEncoding.UTF8, "application/json")).Result;

                        if (responseMessage.IsSuccessStatusCode)
                        {
                            HttpContent responseContent = responseMessage.Content;

                            dynamic responseQSCDService = JArray.Parse(responseContent.ReadAsStringAsync().Result);

                            foreach (JObject assemblyDocumentInfo in responseQSCDService)
                            {
                                signedHash = Convert.FromBase64String(assemblyDocumentInfo.GetValue("hashSig").ToString());
                                break;
                            }
                        }
                    }
                }


                return signedHash;
            }
            catch (IOException e)
            {
                throw new Exception("PdfException", e);
            }
        }
        #endregion // Overridables
    }
}