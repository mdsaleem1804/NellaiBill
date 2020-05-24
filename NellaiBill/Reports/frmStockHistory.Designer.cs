namespace NellaiBill.Reports
{
    partial class frmStockHistory
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
            this.btnViewData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
                this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.mChkSelectAllItem = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewData
            // 
            this.btnViewData.Depth = 0;
            this.btnViewData.Location = new System.Drawing.Point(662, 69);
            this.btnViewData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Primary = true;
            this.btnViewData.Size = new System.Drawing.Size(109, 26);
            this.btnViewData.TabIndex = 36;
            this.btnViewData.Text = "VIEW DATA";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "To Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy/MM/dd";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(195, 76);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(169, 20);
            this.dtpToDate.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy/MM/dd";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(15, 76);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(153, 20);
            this.dtpFromDate.TabIndex = 32;
                       // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(382, 44);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Item Name";
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Items.AddRange(new object[] {
            "All Stock",
            "Negative Stock",
            "Zero Stock",
            "Available Stock"});
            this.cmbItem.Location = new System.Drawing.Point(386, 76);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(172, 21);
            this.cmbItem.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(15, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 33);
            this.panel3.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(404, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Stock History";
            // 
            // mChkSelectAllItem
            // 
            this.mChkSelectAllItem.AutoSize = true;
            this.mChkSelectAllItem.Depth = 0;
            this.mChkSelectAllItem.Font = new System.Drawing.Font("Roboto", 10F);
            this.mChkSelectAllItem.Location = new System.Drawing.Point(561, 69);
            this.mChkSelectAllItem.Margin = new System.Windows.Forms.Padding(0);
            this.mChkSelectAllItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mChkSelectAllItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.mChkSelectAllItem.Name = "mChkSelectAllItem";
            this.mChkSelectAllItem.Ripple = true;
            this.mChkSelectAllItem.Size = new System.Drawing.Size(88, 30);
            this.mChkSelectAllItem.TabIndex = 40;
            this.mChkSelectAllItem.Text = "Select All";
            this.mChkSelectAllItem.UseVisualStyleBackColor = true;
            // 
            // frmStockHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1060, 582);
            this.Controls.Add(this.mChkSelectAllItem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFromDate);
            this.Name = "frmStockHistory";
            this.Text = "frmStockHistory";
            this.Load += new System.EventHandler(this.frmStockHistory_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnViewData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cmbItem;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialCheckBox mChkSelectAllItem;
    }
}