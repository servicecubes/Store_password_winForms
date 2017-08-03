using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePassWindowsApp
{
    class RetrievePass
    {
        public bool checkMasterPassExistance()
        {
            if (File.Exists(@"donotdelete.txt"))
            {
                using (StreamReader sr = new StreamReader(@"donotdelete.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        var line = sr.ReadLine();
                        if (line.Length > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public string retrieveMasterPass()
        {
            TextEncryptionDecryption tcd = new TextEncryptionDecryption();

            var line = " ";
            using (StreamReader sr = new StreamReader(@"donotdelete.txt"))
            {
                line = sr.ReadLine();
            }
            var applicationEncryptionPass = "thisismyapplication.iwillnotgivepasswordtoanyone";

            var value = tcd.DecryptText(line, applicationEncryptionPass);
            return value;
        }

        //public void retrievePass(string webSiteName)
        //{
        //    Console.WriteLine("\n");
        //    var count = 0;
        //    var masterPass = retrieveMasterPass();

        //    using (StreamReader sr = new StreamReader(@"credentials\Cred.txt"))
        //    {
        //        while (sr.Peek() >= 0)
        //        {
        //            var line = sr.ReadLine();
        //            if (webSiteName.ToLower() == line.Split(',')[0].ToLower())
        //            {
        //                count++;
        //                var text = line.Split(',')[2];

        //                Console.WriteLine("Id:\t" + line.Split(',')[1] + "\t\t\tPass:\t" + tcd.DecryptText(text, masterPass));
        //            }
        //        }
        //    }

        //    if (count == 1)
        //    {
        //        Console.WriteLine("\n" + count + " matched item found.\n\nEnd of search.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\n" + count + " matched items found.\n\nEnd of search.");
        //    }
        //}



    }
}
