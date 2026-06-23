namespace WindowsFormNew
{
    partial class Login2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.lblmsgg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(141, 89);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(79, 16);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username : ";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(261, 89);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(139, 22);
            this.txtusername.TabIndex = 1;
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Location = new System.Drawing.Point(141, 136);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(76, 16);
            this.lblpw.TabIndex = 2;
            this.lblpw.Text = "Password : ";
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(261, 136);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(139, 22);
            this.txtpw.TabIndex = 3;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(236, 214);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 4;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lblmsgg
            // 
            this.lblmsgg.AutoSize = true;
            this.lblmsgg.Location = new System.Drawing.Point(154, 306);
            this.lblmsgg.Name = "lblmsgg";
            this.lblmsgg.Size = new System.Drawing.Size(0, 16);
            this.lblmsgg.TabIndex = 5;
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmsgg);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Name = "Login2";
            this.Text = "Login2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Label lblmsgg;
    }
}