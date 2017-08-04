using System;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public partial class formRetrieve : Form
    {
        public formRetrieve()
        {
            InitializeComponent();
        }

        private void linkMainWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (dataValidator())
            {
                formProvideMasterpass FPM = new formProvideMasterpass();
                FPM.ShowDialog(this);
            }            
        }

        private bool dataValidator()
        {
            if (tBoxWebsite.Text.Trim() == "")
            {
                lblEmptyTextWarning.Show();
                return false;
            }
            else if (tBoxWebsite.Text.Contains(","))
            {
                lblSomethingUnexpected.Show();
            }
            else
            {
                return true;
            }

            lblSomethingUnexpected.Show();
            return false;     
        }

        private void formRetrieve_Load(object sender, EventArgs e)
        {
            lblEmptyTextWarning.Hide();
            lblNoCommaIsAllowedWarning.Hide();
            lblSomethingUnexpected.Hide();
        }
    }
}
