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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLedgerSearch = new System.Windows.Forms.Button();
            this.cmbIsHms = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLedgerSearch);
            this.panel1.Controls.Add(this.cmbIsHms);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(25, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 256);
            this.panel1.TabIndex = 3;
            // 
            // btnLedgerSearch
            // 
            this.btnLedgerSearch.BackColor = System.Drawing.Color.Lime;
            this.btnLedgerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedgerSearch.Location = new System.Drawing.Point(268, 16);
            this.btnLedgerSearch.Name = "btnLedgerSearch";
            this.btnLedgerSearch.Size = new System.Drawing.Size(102, 32);
            this.btnLedgerSearch.TabIndex = 63;
            this.btnLedgerSearch.Text = "UPDATE";
            this.btnLedgerSearch.UseVisualStyleBackColor = false;
            // 
            // cmbIsHms
            // 
            this.cmbIsHms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsHms.FormattingEnabled = true;
            this.cmbIsHms.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbIsHms.Location = new System.Drawing.Point(116, 20);
            this.cmbIsHms.Name = "cmbIsHms";
            this.cmbIsHms.Size = new System.Drawing.Size(121, 21);
            this.cmbIsHms.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "IS HMS";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(293, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 58);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "REMOVE\r\n";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // DeveloperDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 560);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackUpRestore);
            this.Controls.Add(this.btnCreateDatabase);
            this.Name = "DeveloperDashboard";
            this.Text = "DeveloperDashboard";
            this.Load += new System.EventHandler(this.DeveloperDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.Button btnBackUpRestore;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cmbIsHms;
        private System.Windows.Forms.Button btnLedgerSearch;
        private System.Windows.Forms.Button btnRemove;
    }
}