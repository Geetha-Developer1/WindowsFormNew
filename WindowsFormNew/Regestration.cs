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
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into User_Regestration values('"+txtfname.Text+"','"+txtlname.Text+"','"+txtpw.Text+"','"+txtcpw.Text+"','"+txtphno.Text+"','"+txtaddress.Text+"')", conn);
            cmd.ExecuteNonQuery();
            txtfname.Text = "";
            txtlname.Text = "";
            txtpw.Text = "";
            txtcpw.Text = "";
            txtphno.Text = "";
            txtaddress.Text = "";
            conn.Close();
            lblresult.Text = "Record Inserted Successfully";
            lblresult.ForeColor = System.Drawing.Color.Green;

        }
    }
}
