using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormNew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsername.ForeColor = System.Drawing.Color.DeepPink;
            txtPassword.ForeColor = System.Drawing.Color.DeepPink;
            lblUsername.ForeColor = System.Drawing.Color.DarkViolet;
            lblPassword.ForeColor = System.Drawing.Color.DarkViolet;
            btnSubmit.Enabled = false;
            txtPassword.Enabled = false;
            lblmsg.ForeColor = System.Drawing.Color.Green;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Insert into Userinfo values('" + txtUsername.Text + "','" + txtPassword.Text + "')", conn);
            //cmd.ExecuteNonQuery();
            //txtUsername.Text = "";
            //txtPassword.Text = "";
            //conn.Close();
            //lblmsg.Text = "Record Inserted Successfully";

           

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Userinfo set Password='" + txtPassword.Text + "' where Username='" + txtUsername.Text + "'", conn);
            cmd.ExecuteNonQuery();
            txtUsername.Text = "";
            txtPassword.Text = "";
            conn.Close();
            lblmsg.Text = "Record Updated Successfully";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Userinfo where Username='" + txtUsername.Text + "'", conn);
            cmd.ExecuteNonQuery();
            txtUsername.Text = "";
            txtPassword.Text = "";
            conn.Close();
            lblmsg.Text = "Record Deleted Successfully";
            
        }

    }
}
