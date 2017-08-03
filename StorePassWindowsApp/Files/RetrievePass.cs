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
    }
}
