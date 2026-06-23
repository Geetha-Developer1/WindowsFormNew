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
            Bindgrid();
        }
        public void Bindgrid()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from User_Regestration",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvdata.DataSource = dt;

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
                conn.Open();
                if (txtpw.Text == txtcpw.Text)
                {
                    SqlCommand cmd = new SqlCommand("Insert into User_Regestration values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtpw.Text + "','" + txtcpw.Text + "','" + txtphno.Text + "','" + txtaddress.Text + "') ", conn);
                    cmd.ExecuteNonQuery();
                    Bindgrid();
                    conn.Close();

                    lblresult.Text = "Record Inserted Successfully";
                    lblresult.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblresult.Text = "Password should be matched with Confirm Password";
                }



            }
            catch
            {
                lblresult.Text = "Please Provide valid Details";
                lblresult.ForeColor= System.Drawing.Color.Red;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtfname.Text = "";
            txtlname.Text = "";
            txtpw.Text = "";
            txtcpw.Text = "";
            txtphno.Text = "";
            txtaddress.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update User_Regestration set firstname='" + txtfname.Text + "' where password='" + txtpw.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                Bindgrid();
                conn.Close();
                lblresult.Text = "Record Updated Successfully";
                lblresult.ForeColor = System.Drawing.Color.Green;


            }
            catch
            {
                lblresult.Text = "Please Provide valid Details";
                lblresult.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from User_Regestration where firstname='" + txtfname.Text + "' ", conn);
                cmd.ExecuteNonQuery();
                Bindgrid();
                conn.Close();
                lblresult.Text = "Record Deleted Successfully";
                lblresult.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                lblresult.Text = "Please Provide valid Details";
                lblresult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UA0O1ET\\SQLEXPRESS;Initial Catalog=ADODotNetDB;Integrated Security=true;");
                conn.Open();
                SqlDataAdapter da=new SqlDataAdapter("select * from User_Regestration where firstname=@Firstname ", conn);
                da.SelectCommand.Parameters.AddWithValue("@Firstname", txtfname.Text);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gvdata.DataSource = ds.Tables[0];
              
              
                conn.Close();
                
            }
            catch
            {
                lblresult.Text = "Please Provide valid Details";
                lblresult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
