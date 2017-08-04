using System;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public partial class formStore : Form
    {
        public formStore()
        {
            InitializeComponent();
        }

        private void linkMainWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnStoreAndAddMore_Click(object sender, EventArgs e)
        {
            lblEmptyTextWarning.Hide();
            lblNoCommaAllowedWarning.Hide();
            lblPasswordSavedSuccessfullyMsg.Hide();

            if (dataValidator())
            {                
                StorePass sp = new StorePass();        
                sp.storePassowrdToFile(tBoxWebsite.Text, tBoxId.Text, tBoxPassword.Text);
                lblPasswordSavedSuccessfullyMsg.Show();
                tBoxWebsite.Clear();
                tBoxId.Clear();
                tBoxPassword.Clear();                
            }
        }

        private void btnStoreAndExit_Click(object sender, EventArgs e)
        {
            lblEmptyTextWarning.Hide();
            lblNoCommaAllowedWarning.Hide();
            lblPasswordSavedSuccessfullyMsg.Hide();

            if (dataValidator())
            {
                StorePass sp = new StorePass();
                sp.storePassowrdToFile(tBoxWebsite.Text, tBoxId.Text, tBoxPassword.Text);
                Close();                
            }
        }


        private bool dataValidator()
        {
            if (tBoxWebsite.Text.Trim() == "" || tBoxId.Text.Trim() == "" || tBoxPassword.Text.Trim() == "")
            {
                lblNoCommaAllowedWarning.Hide();
                lblEmptyTextWarning.Show();
                return false;
            }
            else if (tBoxWebsite.Text.Contains(",") || tBoxId.Text.Contains(",") || tBoxPassword.Text.Contains(","))
            {
                lblEmptyTextWarning.Hide();
                lblNoCommaAllowedWarning.Show();
                return false;
            }
            else
            {
                return true;
            }
        }      

        private void formStore_Load(object sender, EventArgs e)
        {
            lblEmptyTextWarning.Hide();
            lblNoCommaAllowedWarning.Hide();
            lblPasswordSavedSuccessfullyMsg.Hide();
        }
    }
}
