using System;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public partial class formProvideMasterpass : Form
    {
        public formProvideMasterpass()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (dataValidator())
            {
                RetrievePass rp = new RetrievePass();
                if (tBoxMasterpass.Text == rp.retrieveMasterPass())
                {
                    tBoxMasterpass.Clear();
                    formPasswords frmPasswords = new formPasswords();
                    frmPasswords.ShowDialog(this);
                    Close();                    
                }
                else
                {
                    tBoxMasterpass.Clear();
                    MessageBox.Show("Spammer detected!");
                    Application.Exit();
                }
            }
        }

        private bool dataValidator()
        {
            if (tBoxMasterpass.Text.Trim() == "")
            {
                lblEmptyTextWarning.Show();
                return false;
            }
            else
            {
                lblEmptyTextWarning.Hide();
                return true;
            }            
        }

        private void formProvideMasterpass_Load(object sender, EventArgs e)
        {
            lblEmptyTextWarning.Hide();
        }
    }
}
