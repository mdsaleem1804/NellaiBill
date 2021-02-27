namespace NellaiBill.Master
{
    partial class frmForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgetPassword));
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnpasswordupdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.BackColor = System.Drawing.Color.DarkMagenta;
            this.Label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(-1, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(833, 50);
            this.Label5.TabIndex = 63;
            this.Label5.Text = "Forget Password Form";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Panel1.Controls.Add(this.LogoPictureBox);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.btnpasswordupdate);
            this.Panel1.Controls.Add(this.txtEmail);
            this.Panel1.Location = new System.Drawing.Point(116, 129);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(613, 266);
            this.Panel1.TabIndex = 64;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(16, 27);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(180, 204);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 61;
            this.LogoPictureBox.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Label2.Location = new System.Drawing.Point(296, 68);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 24);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Email :";
            // 
            // btnpasswordupdate
            // 
            this.btnpasswordupdate.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnpasswordupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpasswordupdate.BackgroundImage")));
            this.btnpasswordupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpasswordupdate.FlatAppearance.BorderSize = 0;
            this.btnpasswordupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpasswordupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpasswordupdate.ForeColor = System.Drawing.Color.White;
            this.btnpasswordupdate.Location = new System.Drawing.Point(397, 117);
            this.btnpasswordupdate.Name = "btnpasswordupdate";
            this.btnpasswordupdate.Size = new System.Drawing.Size(147, 57);
            this.btnpasswordupdate.TabIndex = 15;
            this.btnpasswordupdate.Text = "&Show Password";
            this.btnpasswordupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpasswordupdate.UseVisualStyleBackColor = false;
            this.btnpasswordupdate.Click += new System.EventHandler(this.btnpasswordupdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkViolet;
            this.txtEmail.Location = new System.Drawing.Point(397, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '•';
            this.txtEmail.Size = new System.Drawing.Size(200, 29);
            this.txtEmail.TabIndex = 13;
            // 
            // frmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NellaiBill.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(844, 485);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label5);
            this.Name = "frmForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgetPassword";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnpasswordupdate;
        internal System.Windows.Forms.TextBox txtEmail;

    }
}