using System.Collections;
using System.Collections.Generic;
using System.IO;
using iText.IO.Font;
using iText.Kernel.Pdf;
using iText.Signatures;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace SignalPdf
{
    public class ClientServerSigning
    {
        #region Properties
        public string SourcePlainPdf { get; set; }
        public string DestinationSignedPdf { get; set; }
        public string SignatureFieldName { get; set; }
        public string AuthenticationToken { get; set; }
        public string QscdServerBaseAddress { get; set; }
        public string CertificateAlias { get; set; }
        public string Seed { get; set; }
        public string Secret { get; set; }
        public string Reason { get; set; }
        public string Location { get; set; }
        public string HashAlgorithmOID { get; set; }
        public Stream CertificateChain { get; set; }
        #endregion

        public void Sign()
        {
            CmsSignedData certificateStore = new CmsSignedData(CertificateChain);
            IX509Store x509Certs = certificateStore.GetCertificates("Collection");
            ArrayList certificateArray = new ArrayList(x509Certs.GetMatches(null));

            List<X509Certificate> certificates = new List<X509Certificate>();
            foreach (var certificate in certificateArray)
            {
                certificates.Add((X509Certificate)certificate);
            }

            PdfReader pdfReader = new PdfReader(SourcePlainPdf);
            pdfReader.SetUnethicalReading(true);

            StampingProperties stampingProperties = new StampingProperties();
            stampingProperties.UseAppendMode();

            PdfSigner pdfSigner = new PdfSigner(pdfReader,
                new FileStream(DestinationSignedPdf, FileMode.OpenOrCreate), stampingProperties);

            pdfSigner.GetSignatureAppearance().SetPageNumber(1).SetReason(Reason).SetLocation(Location);
            pdfSigner.SetFieldName(SignatureFieldName);

            IExternalSignature pks = new ServerSignature(SourcePlainPdf, AuthenticationToken,
                QscdServerBaseAddress, CertificateAlias, Seed, Secret, HashAlgorithmOID);

            pdfSigner.SignDetached(pks, certificates.ToArray(), null, null, null, 0, PdfSigner.CryptoStandard.CMS);

        }
    }
}
