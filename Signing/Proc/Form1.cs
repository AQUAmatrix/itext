using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SignalPdf;

namespace SignPDF_Proc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtCertAlias.Text = ConfigurationManager.AppSettings.Get("CertAlias");
            txtCertificatePath.Text = txtCertificatePath.Text + txtCertAlias.Text + ".p7b";
            txtCertFriendlyName.Text = ConfigurationManager.AppSettings.Get("CertFriendlyName");
            txtHashAlg.Text = ConfigurationManager.AppSettings.Get("HashAlg");
            txtAuthId.Text = ConfigurationManager.AppSettings.Get("AuthId");
            txtAuthSecret.Text = ConfigurationManager.AppSettings.Get("AuthSecret");
            txtAccessToken.Text = ConfigurationManager.AppSettings.Get("AccessToken");
            txtCertifURI.Text = ConfigurationManager.AppSettings.Get("CertifURI");
            txtReason.Text = ConfigurationManager.AppSettings.Get("Reason");
            txtLocation.Text = ConfigurationManager.AppSettings.Get("Location");
            txt64Encode.Text = ConfigurationManager.AppSettings.Get("64Encode");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<clError> errorList = new List<clError>();
            errorList = SignFromDir();

            foreach (clError error in errorList)
            {
                string output = error.code + ": " + error.description;
                if (String.IsNullOrEmpty(txtLog.Text))
                    txtLog.AppendText(output);
                else
                    txtLog.AppendText(Environment.NewLine + output);

                txtLog.ScrollToCaret();
            }
        }

        private void CheckCertificate(string certificatePath)
        {
            if (!File.Exists(certificatePath))
                throw new Exception("Ceritificado não encontrado.");
        }

        private void CheckFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new Exception("Ficheiro de Origem não encontrado");
        }

        private void CheckFolder(string folderPath, bool src)
        {
            if (!Directory.Exists(folderPath))
            {
                if (src)
                    throw new Exception("Directoria de Origem não encontrado");
                else
                    Directory.CreateDirectory(folderPath);
            }
        }

        private void Sign(string srcFile, string dtsFile)
        {
            try
            {
                UriBuilder uri = new UriBuilder(txtCertifURI.Text);

                using (FileStream certificado = new FileStream(txtCertificatePath.Text, FileMode.Open))
                {
                    SignalPdf.ClientServerSigning clientServerSigning = new SignalPdf.ClientServerSigning
                    {
                        SourcePlainPdf = srcFile,
                        DestinationSignedPdf = dtsFile,
                        SignatureFieldName = txtCertFriendlyName.Text,
                        CertificateChain = certificado,
                        AuthenticationToken = txtAccessToken.Text,
                        QscdServerBaseAddress = uri.Scheme + "://" + uri.Host,
                        CertificateAlias = txtCertAlias.Text,
                        Seed = txtAuthId.Text,
                        Secret = txtAuthSecret.Text,
                        HashAlgorithmOID = txtHashAlg.Text,
                        Reason = txtReason.Text,
                        Location = txtLocation.Text,
                    };

                    clientServerSigning.Sign();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File: " + txtSrc.Text + ". " + ex.Message + ex.InnerException + ex.StackTrace);
            }
        }

        public List<clError> SignFromDir()
        {
            List<clError> errorList = new List<clError>();
            clError error = new clError();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            try
            {
                CheckCertificate(txtCertificatePath.Text);
                CheckFolder(txtSrc.Text, true);
                CheckFolder(txtDst.Text, false);

                foreach (string file in Directory.GetFiles(txtSrc.Text))
                {
                    string fileName = Path.GetFileName(file);
                    string extension = Path.GetExtension(file);
                    if (extension.ToLower() == ".pdf")
                    {
                        Sign(file, Path.Combine(txtDst.Text, fileName));
                    }
                }
            }
            catch (Exception ex)
            {
                clError _error = new clError();
                _error.code = -99;
                _error.description = "Erro: " + ex.Message;

                errorList.Add(_error);
            }

            if (errorList.Count == 0)
            {
                clError _error = new clError();
                _error.code = 0;
                _error.description = "Success";
                errorList.Add(_error);
            }

            return errorList;
        }
    }
}
