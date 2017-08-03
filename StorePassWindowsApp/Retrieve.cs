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
    public partial class formRetrieve : Form
    {
        public formRetrieve()
        {
            InitializeComponent();
        }

        private void linkMainWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
