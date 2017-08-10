using System;
using System.IO;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public partial class formPasswords : Form
    {
        public formPasswords()
        {
            InitializeComponent();
        }

        private void formPasswords_Load(object sender, EventArgs e)
        {
            // Getting the UI ready for displaying passwords.
            MinimumSize = new System.Drawing.Size(Width, Height);
            MaximumSize = new System.Drawing.Size(3000, 2000);
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            
            // Displaying passowrds now.
            displayPasswords();
        }

        private void displayPasswords()
        {
            int txtBoxStartPositionId = 12;
            int txtBoxStartPositionVId = 30;
            int txtBoxStartPositionPass = 230;
            int txtBoxStartPositionVPass = 30;

            RetrievePass rp = new RetrievePass();
            TextEncryptionDecryption tcd = new TextEncryptionDecryption();
            var count = 0;
            var masterPass = rp.retrieveMasterPass();


            using (StreamReader sr = new StreamReader(@"credentials\Cred.txt"))
            {
                while (sr.Peek() >= 0)
                {                    
                    var line = sr.ReadLine();

                    if (GlobalVariables.websiteName.ToLower() == line.Split(',')[0].ToLower())
                    {
                        var id = line.Split(',')[1];
                        var encryptedPass = line.Split(',')[2];
                        var passInPlainText = tcd.DecryptText(encryptedPass, masterPass);

                        count++;

                        // Displaying Id fields.
                        TextBox tBoxId = new TextBox();
                        tBoxId.Location = new System.Drawing.Point(txtBoxStartPositionId, txtBoxStartPositionVId);
                        tBoxId.Size = new System.Drawing.Size(200, 30);
                        tBoxId.Text = id.ToString();

                        Controls.Add(tBoxId);
                        txtBoxStartPositionVId += 30;

                        // Displaying Password fields.
                        TextBox tBoxPass = new TextBox();
                        tBoxPass.Location = new System.Drawing.Point(txtBoxStartPositionPass, txtBoxStartPositionVPass);
                        tBoxPass.Size = new System.Drawing.Size(200, 30);
                        tBoxPass.Text = id.ToString();

                        Controls.Add(tBoxPass);
                        txtBoxStartPositionVPass += 30;

                        var text = line.Split(',')[2];                        
                    }
                }
            }

            GlobalVariables.passwordCount = count;
            Text = "Website = " + GlobalVariables.websiteName + " :: Passwords Found = " + GlobalVariables.passwordCount;         
        }
        
        
             

    }
}
