namespace NellaiBill.Master
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkChangePassword = new System.Windows.Forms.LinkLabel();
            this.linkForgetPassword = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(293, 88);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(97, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "USER NAME";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(293, 136);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(95, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(409, 83);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(185, 25);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "user";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(409, 136);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(185, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "user";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::NellaiBill.Properties.Resources.bg;
            this.groupBox1.Controls.Add(this.linkChangePassword);
            this.groupBox1.Controls.Add(this.linkForgetPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(354, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 365);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // linkChangePassword
            // 
            this.linkChangePassword.AutoSize = true;
            this.linkChangePassword.BackColor = System.Drawing.Color.PaleGreen;
            this.linkChangePassword.LinkColor = System.Drawing.Color.Black;
            this.linkChangePassword.Location = new System.Drawing.Point(293, 310);
            this.linkChangePassword.Name = "linkChangePassword";
            this.linkChangePassword.Size = new System.Drawing.Size(122, 17);
            this.linkChangePassword.TabIndex = 6;
            this.linkChangePassword.TabStop = true;
            this.linkChangePassword.Text = "Change Password?";
            this.linkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePassword_LinkClicked);
            // 
            // linkForgetPassword
            // 
            this.linkForgetPassword.AutoSize = true;
            this.linkForgetPassword.BackColor = System.Drawing.Color.PaleGreen;
            this.linkForgetPassword.LinkColor = System.Drawing.Color.Black;
            this.linkForgetPassword.Location = new System.Drawing.Point(292, 268);
            this.linkForgetPassword.Name = "linkForgetPassword";
            this.linkForgetPassword.Size = new System.Drawing.Size(116, 17);
            this.linkForgetPassword.TabIndex = 5;
            this.linkForgetPassword.TabStop = true;
            this.linkForgetPassword.Text = "Forget Password?";
            this.linkForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgetPassword_LinkClicked);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::NellaiBill.Properties.Resources.clear_icon;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(456, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Image = global::NellaiBill.Properties.Resources.tick;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogin.Location = new System.Drawing.Point(296, 196);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NellaiBill.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1028, 514);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkForgetPassword;
        private System.Windows.Forms.LinkLabel linkChangePassword;
    }
}