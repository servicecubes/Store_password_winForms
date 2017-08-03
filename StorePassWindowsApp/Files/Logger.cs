using System;
using System.IO;

namespace StorePassWindowsApp
{
    public class Logger
    {
        public void log(string logText)
        {
            File.AppendAllText(@"log.txt", DateTime.Now + " - " + logText + "\n");
        }
    }
}

