namespace NellaiBill.Common
{
    partial class DeveloperDashboard
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
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.btnBackUpRestore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Location = new System.Drawing.Point(25, 12);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(99, 58);
            this.btnCreateDatabase.TabIndex = 0;
            this.btnCreateDatabase.Text = "CREATE DATABASE";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // btnBackUpRestore
            // 
            this.btnBackUpRestore.Location = new System.Drawing.Point(163, 12);
            this.btnBackUpRestore.Name = "btnBackUpRestore";
            this.btnBackUpRestore.Size = new System.Drawing.Size(99, 58);
            this.btnBackUpRestore.TabIndex = 2;
            this.btnBackUpRestore.Text = "BACK UP AND RESTORE";
            this.btnBackUpRestore.UseVisualStyleBackColor = true;
            this.btnBackUpRestore.Click += new System.EventHandler(this.btnBackUpRestore_Click);
            // 
            // DeveloperDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 560);
            this.Controls.Add(this.btnBackUpRestore);
            this.Controls.Add(this.btnCreateDatabase);
            this.Name = "DeveloperDashboard";
            this.Text = "DeveloperDashboard";
            this.Load += new System.EventHandler(this.DeveloperDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.Button btnBackUpRestore;
    }
}