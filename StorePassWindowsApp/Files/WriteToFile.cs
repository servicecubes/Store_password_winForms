using System;
using System.IO;

namespace StorePassWindowsApp
{
    public class WriteToFile
    {
        TextEncryptionDecryption tcd1 = new TextEncryptionDecryption();

        public void writePassOnCredentialFile(string webSite, string id, string password, string masterPass)
        {
            if (!Directory.Exists(@"credentials"))
            {
                Directory.CreateDirectory(@"credentials");
            }

            var encryptedPass = tcd1.EncryptText(password, masterPass);
            string credential = webSite + "," + id + "," + encryptedPass;

            File.AppendAllText(@"credentials\Cred.txt", credential.ToString());
            File.AppendAllText(@"credentials\Cred.txt", "\n");            
        }
    }
}

