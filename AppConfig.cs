using System.Configuration;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace RequestSigner
{
    internal static class AppConfig
    {
        public static readonly string CertificatePath = ConfigurationManager.AppSettings["CertificatePath"];
        public static readonly string CertificatePassword = ConfigurationManager.AppSettings["CertificatePassword"];

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Error message if error exists or empty string if valid</returns>
        public static string ValidateConfig()
        {
            if (string.IsNullOrEmpty(CertificatePath)) return "CertificatePath missing from App.config";
            if (!File.Exists(CertificatePath)) return "CertificatePath does not exist on disk";

            if (string.IsNullOrEmpty(CertificatePassword)) return "CertificatePassword missing from App.config";

            try
            {
                new X509Certificate2(AppConfig.CertificatePath, AppConfig.CertificatePassword,
                    X509KeyStorageFlags.Exportable | X509KeyStorageFlags.MachineKeySet);
            }
            catch (CryptographicException ex)
            {
                return ex.Message;
            }

            return string.Empty;
        }
    }
}
