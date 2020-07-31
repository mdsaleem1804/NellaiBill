namespace NellaiBill.Transaction
{
    partial class PurchaseEntryEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPurchaseId = new System.Windows.Forms.TextBox();
            this.btnUpdatePurchase = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnLedgerSearch = new System.Windows.Forms.Button();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpPEDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPurchaseId);
            this.panel1.Controls.Add(this.btnUpdatePurchase);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dtpPEDate);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(20, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 188);
            this.panel1.TabIndex = 79;
            // 
            // txtPurchaseId
            // 
            this.txtPurchaseId.Enabled = false;
            this.txtPurchaseId.Location = new System.Drawing.Point(91, 19);
            this.txtPurchaseId.Name = "txtPurchaseId";
            this.txtPurchaseId.Size = new System.Drawing.Size(111, 20);
            this.txtPurchaseId.TabIndex = 205;
            // 
            // btnUpdatePurchase
            // 
            this.btnUpdatePurchase.BackColor = System.Drawing.Color.Lime;
            this.btnUpdatePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePurchase.Location = new System.Drawing.Point(882, 11);
            this.btnUpdatePurchase.Name = "btnUpdatePurchase";
            this.btnUpdatePurchase.Size = new System.Drawing.Size(112, 65);
            this.btnUpdatePurchase.TabIndex = 80;
            this.btnUpdatePurchase.Text = "UPDATE";
            this.btnUpdatePurchase.UseVisualStyleBackColor = false;
            this.btnUpdatePurchase.Click += new System.EventHandler(this.btnUpdatePurchase_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 205;
            this.label3.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnLedgerSearch);
            this.groupBox1.Controls.Add(this.txtSupplierId);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtMobileNo);
            this.groupBox1.Controls.Add(this.rchAddress);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(18, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 128);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Details";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(172, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(283, 24);
            this.txtName.TabIndex = 204;
            // 
            // btnLedgerSearch
            // 
            this.btnLedgerSearch.BackColor = System.Drawing.Color.Lime;
            this.btnLedgerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedgerSearch.Location = new System.Drawing.Point(9, 24);
            this.btnLedgerSearch.Name = "btnLedgerSearch";
            this.btnLedgerSearch.Size = new System.Drawing.Size(84, 61);
            this.btnLedgerSearch.TabIndex = 62;
            this.btnLedgerSearch.Text = "SEARCH (CTRL+L)";
            this.btnLedgerSearch.UseVisualStyleBackColor = false;
            this.btnLedgerSearch.Click += new System.EventHandler(this.btnLedgerSearch_Click);
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Location = new System.Drawing.Point(172, 17);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(111, 24);
            this.txtSupplierId.TabIndex = 203;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(99, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 20);
            this.label20.TabIndex = 202;
            this.label20.Text = "Id";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Enabled = false;
            this.txtMobileNo.Location = new System.Drawing.Point(560, 12);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(266, 24);
            this.txtMobileNo.TabIndex = 201;
            // 
            // rchAddress
            // 
            this.rchAddress.Enabled = false;
            this.rchAddress.Location = new System.Drawing.Point(560, 39);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(266, 83);
            this.rchAddress.TabIndex = 200;
            this.rchAddress.Text = "";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(99, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 20);
            this.label22.TabIndex = 10;
            this.label22.Text = "Name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(461, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(79, 20);
            this.label24.TabIndex = 38;
            this.label24.Text = "Mobile No";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(461, 46);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 20);
            this.label26.TabIndex = 35;
            this.label26.Text = "Address";
            // 
            // dtpPEDate
            // 
            this.dtpPEDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPEDate.Location = new System.Drawing.Point(339, 20);
            this.dtpPEDate.Name = "dtpPEDate";
            this.dtpPEDate.Size = new System.Drawing.Size(143, 20);
            this.dtpPEDate.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 25);
            this.label17.TabIndex = 34;
            this.label17.Text = "InvNo";
            // 
            // PurchaseEntryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseEntryEdit";
            this.Text = "PurchaseEntryEdit";
            this.Load += new System.EventHandler(this.PurchaseEntryEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnLedgerSearch;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.RichTextBox rchAddress;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker dtpPEDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnUpdatePurchase;
        private System.Windows.Forms.TextBox txtPurchaseId;
    }
}