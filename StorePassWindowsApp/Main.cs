using System;
using System.Windows.Forms;

namespace StorePassWindowsApp
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {            
            formStore frmStore = new formStore();
            frmStore.ShowDialog(this);
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            formRetrieve frmRetrieve = new formRetrieve();
            frmRetrieve.ShowDialog(this);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            RetrievePass rp = new RetrievePass();

            var masterPassExists = rp.checkMasterPassExistance();
            if (masterPassExists != true)
            {
                // #IMP: Need to write code so that main window is closed. Need more research.
                formSetupMasterpass frmSMP = new formSetupMasterpass();
                frmSMP.ShowDialog(this);
            }
            masterPassExists = rp.checkMasterPassExistance();
            if (masterPassExists != true)
            {
                MessageBox.Show("You must setup a masterpass to use this application!");
                this.Close();                
            }            
        }
    }
}