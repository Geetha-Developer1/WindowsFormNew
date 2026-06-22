using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnSubmit.Enabled = false;
            btnSubmit.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Hellow " + txtUsername.Text+",Successfully Login With Your Password : "+txtPassword.Text);

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {
                btnSubmit.Visible = true;
            }
            else
            {
                btnSubmit.Visible = false;
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length>0)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }
    }
}
