using System;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public static class GlobalVariables
    {
        public static bool ifAnyPasswordWasFoundForThisWebsite;
        public static string websiteName;
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
