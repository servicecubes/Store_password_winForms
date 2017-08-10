﻿using System;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public static class GlobalVariables
    {
        public static bool ifAnyPasswordWasFoundForThisWebsite;
        public static string websiteName;
        public static int passwordCount;
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMain());
        }
    }
}
