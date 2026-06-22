namespace WindowsFormNew
{
    partial class ArithmaticCalculations
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
            this.lblfnum = new System.Windows.Forms.Label();
            this.lblsnum = new System.Windows.Forms.Label();
            this.txtfnum = new System.Windows.Forms.TextBox();
            this.txtsnum = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfnum
            // 
            this.lblfnum.AutoSize = true;
            this.lblfnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfnum.Location = new System.Drawing.Point(107, 93);
            this.lblfnum.Name = "lblfnum";
            this.lblfnum.Size = new System.Drawing.Size(205, 25);
            this.lblfnum.TabIndex = 0;
            this.lblfnum.Text = "Enter First Number :";
            // 
            // lblsnum
            // 
            this.lblsnum.AutoSize = true;
            this.lblsnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnum.Location = new System.Drawing.Point(107, 151);
            this.lblsnum.Name = "lblsnum";
            this.lblsnum.Size = new System.Drawing.Size(243, 25);
            this.lblsnum.TabIndex = 1;
            this.lblsnum.Text = "Enter Second Number : ";
            // 
            // txtfnum
            // 
            this.txtfnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfnum.Location = new System.Drawing.Point(358, 93);
            this.txtfnum.Name = "txtfnum";
            this.txtfnum.Size = new System.Drawing.Size(183, 30);
            this.txtfnum.TabIndex = 2;
            // 
            // txtsnum
            // 
            this.txtsnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsnum.Location = new System.Drawing.Point(358, 155);
            this.txtsnum.Name = "txtsnum";
            this.txtsnum.Size = new System.Drawing.Size(183, 30);
            this.txtsnum.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(80, 240);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(117, 44);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Addition";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsub
            // 
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(219, 240);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(152, 44);
            this.btnsub.TabIndex = 5;
            this.btnsub.Text = "Subtraction";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmul
            // 
            this.btnmul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.Location = new System.Drawing.Point(396, 240);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(169, 44);
            this.btnmul.TabIndex = 6;
            this.btnmul.Text = "Multiplication";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(590, 240);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(117, 44);
            this.btndiv.TabIndex = 7;
            this.btndiv.Text = "Division";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblres.Location = new System.Drawing.Point(126, 390);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(0, 25);
            this.lblres.TabIndex = 8;
            // 
            // ArithmaticCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 543);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtsnum);
            this.Controls.Add(this.txtfnum);
            this.Controls.Add(this.lblsnum);
            this.Controls.Add(this.lblfnum);
            this.Name = "ArithmaticCalculations";
            this.Text = "ArithmaticCalculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfnum;
        private System.Windows.Forms.Label lblsnum;
        private System.Windows.Forms.TextBox txtfnum;
        private System.Windows.Forms.TextBox txtsnum;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Label lblres;
    }
}