using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RequestSigner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateSignature(object sender, EventArgs e)
        {
            string validationError = AppConfig.ValidateConfig();
            if (!string.IsNullOrEmpty(validationError))
            {
                MessageBox.Show(validationError);
                return;
            }

            string request = RequestTextbox.Text;

            string payload = SanitizeJsonString(request);
            if (string.IsNullOrEmpty(payload))
            {
                MessageBox.Show("Invalid Json");
                return;
            }

            string signature = JwtHelper.GetDetachedToken(payload);
            SignatureTextbox.Text = signature;
        }

        private string SanitizeJsonString(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            try
            {
                object deserialized = JsonConvert.DeserializeObject(input);
                return JsonConvert.SerializeObject(deserialized).Trim();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private void Certificate2Base64(object sender, EventArgs e)
        {
            string filePath;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                filePath = openFileDialog.FileName;
            }

            try
            {
                var certificate = new X509Certificate2(filePath);
                //byte[] rawData = System.IO.File.ReadAllBytes(filePath);
                string base64encoded = Convert.ToBase64String(certificate.RawData);
                CertificatTextbox.Text = base64encoded;
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("Failed to create X509Certificate2 from selected file");
                CertificatTextbox.Text = JsonConvert.SerializeObject(ex);
            }
        }
    }
}
