using System;
using System.IO;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public partial class formSetupMasterpass : Form
    {
        public formSetupMasterpass()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            var input1 = tBoxMasterpassInput1.Text;
            var input2 = tBoxMasterpassInput2.Text;

            // Check if both inputs are not same, show warning and stay in form.
            if (input1 != input2)
            {
                if (input1.Trim() == "" && input2.Trim() == "")
                {
                    lblNotMatchWarning.Hide();
                    lblEmptyTextWarning.Show();
                }
                else
                {
                    lblEmptyTextWarning.Hide();
                    lblNotMatchWarning.Show();
                }
            }
            // If both inputs are same and if yes, set it up as masterpass if input value is not blank.
            else
            {
                if (input1.Trim() == "")
                {
                    lblNotMatchWarning.Hide();
                    lblEmptyTextWarning.Show();
                }
                else
                {
                    lblNotMatchWarning.Hide();
                    lblEmptyTextWarning.Hide();

                    TextEncryptionDecryption tcd = new TextEncryptionDecryption();

                    var applicationEncryptionPass = "thisismyapplication.iwillnotgivepasswordtoanyone";

                    var encryptedPass = tcd.EncryptText(input1,applicationEncryptionPass);
                    File.AppendAllText(@"donotdelete.txt", encryptedPass.ToString());
                    MessageBox.Show("Your masterpassword has been saved successfully!");
                }
            }

            // Check to see if masterpass was set properly. If yes, close the form and return to main.
            RetrievePass rp = new RetrievePass();

            if (rp.checkMasterPassExistance() == true)
            {
                this.Close();
            }
        }

        private void formSetupMasterpass_Load(object sender, EventArgs e)
        {
            lblNotMatchWarning.Hide();
            lblEmptyTextWarning.Hide();
        }
    }
}
