namespace NellaiBill.Reports
{
    partial class StockReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbStockType = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mChkSelectAllItem = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnLogs = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewData
            // 
            this.btnViewData.Depth = 0;
            this.btnViewData.Location = new System.Drawing.Point(227, 12);
            this.btnViewData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Primary = true;
            this.btnViewData.Size = new System.Drawing.Size(106, 44);
            this.btnViewData.TabIndex = 0;
            this.btnViewData.Text = "VIEW STOCK  DATA";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // cmbStockType
            // 
            this.cmbStockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockType.FormattingEnabled = true;
            this.cmbStockType.Items.AddRange(new object[] {
            "All Stock",
            "Negative Stock",
            "Zero Stock",
            "Available Stock"});
            this.cmbStockType.Location = new System.Drawing.Point(26, 31);
            this.cmbStockType.Name = "cmbStockType";
            this.cmbStockType.Size = new System.Drawing.Size(172, 21);
            this.cmbStockType.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Stock Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Search Here..";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(123, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // mChkSelectAllItem
            // 
            this.mChkSelectAllItem.AutoSize = true;
            this.mChkSelectAllItem.Checked = true;
            this.mChkSelectAllItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mChkSelectAllItem.Depth = 0;
            this.mChkSelectAllItem.Font = new System.Drawing.Font("Roboto", 10F);
            this.mChkSelectAllItem.Location = new System.Drawing.Point(944, 14);
            this.mChkSelectAllItem.Margin = new System.Windows.Forms.Padding(0);
            this.mChkSelectAllItem.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mChkSelectAllItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.mChkSelectAllItem.Name = "mChkSelectAllItem";
            this.mChkSelectAllItem.Ripple = true;
            this.mChkSelectAllItem.Size = new System.Drawing.Size(88, 30);
            this.mChkSelectAllItem.TabIndex = 82;
            this.mChkSelectAllItem.Text = "Select All";
            this.mChkSelectAllItem.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(858, 18);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 81;
            this.materialLabel2.Text = "Item Name";
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(859, 47);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(197, 21);
            this.cmbItem.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "To Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(633, 82);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(180, 20);
            this.dtpToDate.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy/MM/dd hh:mm:ss tt";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(633, 36);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(180, 20);
            this.dtpFromDate.TabIndex = 76;
            // 
            // btnLogs
            // 
            this.btnLogs.Depth = 0;
            this.btnLogs.Location = new System.Drawing.Point(859, 74);
            this.btnLogs.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Primary = true;
            this.btnLogs.Size = new System.Drawing.Size(197, 37);
            this.btnLogs.TabIndex = 75;
            this.btnLogs.Text = "VIEW LOGS";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(631, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(623, 394);
            this.dataGridView2.TabIndex = 83;
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1283, 552);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.mChkSelectAllItem);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbStockType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnViewData);
            this.Name = "StockReport";
            this.Text = "StockReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnViewData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbStockType;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearch;
        private MaterialSkin.Controls.MaterialCheckBox mChkSelectAllItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogs;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}