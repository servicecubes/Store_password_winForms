using System;
using System.IO;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public class CustomControls : Form
    {
        private TextBox tBoxId = new TextBox();
        private TextBox tBoxPassword = new TextBox();
        private Button btnCopyToClipBoard = new Button();
    }

    public partial class formPasswords : Form
    {
        public formPasswords()
        {
            InitializeComponent();
        }

        private void formPasswords_Load(object sender, EventArgs e)
        {
            RetrievePass rp = new RetrievePass();
            var count = 0;
            var masterPass = rp.retrieveMasterPass();

            CustomControls cc = new CustomControls();
            cc.Controls.Add(new TextBox());

            // Reading from the password file and displating them on the form.
            // Code is not written yet.

            //using (StreamReader sr = new StreamReader(@"credentials\Cred.txt"))
            //{
            //    while (sr.Peek() >= 0)
            //    {
            //        var line = sr.ReadLine();
            //        // Get the website name from the last form.
            //        if (GlobalVariables.websiteName.ToLower() == line.Split(',')[0].ToLower())
            //        {
            //            count++;
            //            var text = line.Split(',')[2];

            //            Console.WriteLine("Id:\t" + line.Split(',')[1] + "\t\t\tPass:\t" + tcd.DecryptText(text, masterPass));
            //        }
            //    }

            if (count == 0)
            {
                MessageBox.Show("Sorry, nothing was found for website: [" + GlobalVariables.websiteName + "].");
                Close();
            }
            else if (count == 1)
            {
                lblCountDisplayText.Text = count + " result found.";
                lblCountDisplayText.Show();
            }
            else
            {
                lblCountDisplayText.Text = count + " results found.";
                lblCountDisplayText.Show();
            }


        }






    }

}
