using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormNew
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=192.168.1.47;Initial Catalog=MyData;Integrated Security=true;");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into UsersInfo values('" + txtusername.Text + "' ,'" + txtpw.Text + "' )", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                lblmsgg.Text = "Record Updated Successfully";
                lblmsgg.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                lblmsgg.Text = "Please provide valid Details";
                lblmsgg.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
