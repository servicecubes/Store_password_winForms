using System;
using System.IO;

namespace StorePassWindowsApp
{
    public class WriteToFile
    {
        TextEncryptionDecryption tcd1 = new TextEncryptionDecryption();

        public void writePassOnCredentialFile(string webSite, string id, string password, string masterPass)
        {
            var encryptedPass = tcd1.EncryptText(password, masterPass);
            string credential = webSite + "," + id + "," + encryptedPass;

            File.AppendAllText(@"credentials\Cred.txt", credential.ToString());
            File.AppendAllText(@"credentials\Cred.txt", "\n");

            Console.WriteLine("\nYour credentials are saved successfully to application database.");
        }
    }
}

