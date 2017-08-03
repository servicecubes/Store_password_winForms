using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Close();
        }

        private void btnStoreAndAddMore_Click(object sender, EventArgs e)
        {

        }

        private void btnStoreAndExit_Click(object sender, EventArgs e)
        {

        }        
    }
}
