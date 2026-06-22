using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormNew
{
    public partial class ArithmaticCalculations : Form
    { 
        public ArithmaticCalculations()
        {
            InitializeComponent();
            txtfnum.ForeColor = System.Drawing.Color.Blue;
            txtsnum.ForeColor = System.Drawing.Color.Blue;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtfnum.Text);
                int b = int.Parse(txtsnum.Text);
                lblres.Text = "Addition Result is : " + (a + b);
                lblres.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                lblres.Text = "Please enter valid Details";
                lblres.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtfnum.Text);
                int b = int.Parse(txtsnum.Text);
                lblres.Text = "Subtraction Result is : " + (a - b);
                lblres.ForeColor = System.Drawing.Color.Brown;

            }
            catch
            {
                lblres.Text = "Please enter valid Details";
                lblres.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtfnum.Text);
                int b = int.Parse(txtsnum.Text);
                lblres.Text = "Multiplication Result is : " + (a * b);
                lblres.ForeColor = System.Drawing.Color.DeepPink;

            }
            catch
            {
                lblres.Text = "Please enter valid Details";
                lblres.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtfnum.Text);
                int b = int.Parse(txtsnum.Text);
                lblres.Text = "Division Result is : " + (a / b);
                lblres.ForeColor = System.Drawing.Color.Purple;

            }
            catch
            {
                lblres.Text = "Please enter valid Details";
                lblres.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
