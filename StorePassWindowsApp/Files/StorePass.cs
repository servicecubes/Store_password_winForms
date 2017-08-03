using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorePassWindowsApp
{
    class StorePass
    {
        WriteToFile write = new WriteToFile();
        RetrievePass rp = new RetrievePass();

        public void storePassowrdToFile(string webSiteName, string id, string pass)
        {
            var masterPass = rp.retrieveMasterPass();
            write.writePassOnCredentialFile(webSiteName, id, pass, masterPass);
        }
    }
}
