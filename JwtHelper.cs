using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Jose;

namespace RequestSigner
{
    internal class JwtHelper
    {
        internal static string GetDetachedToken(string payload)
        {
            X509Certificate2 privateCertificate = PrivateKeyTpp();

            RSA key = privateCertificate.GetRSAPrivateKey();

            var tppToken = JWT.Encode(payload, key, JwsAlgorithm.RS256);

            var tppTokenParts = tppToken.Split('.');
            var tppDetachedToken = tppTokenParts[0] + ".." + tppTokenParts[2];

            return tppDetachedToken;
        }


        internal static X509Certificate2 PrivateKeyTpp()
        {
            return new X509Certificate2(AppConfig.CertificatePath, AppConfig.CertificatePassword,
                X509KeyStorageFlags.Exportable | X509KeyStorageFlags.MachineKeySet);
        }
    }
}
