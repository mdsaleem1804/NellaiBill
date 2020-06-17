namespace NellaiBill.Master
{
    partial class frmItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHsnCode = new System.Windows.Forms.TextBox();
            this.mBtnSaveUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExcel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPDF = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbTax = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mBtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(17, 34);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(173, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 232);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 409);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(408, 35);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(283, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product Name";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(212, 34);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(173, 21);
            this.cmbGroup.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Group";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbTax);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtHsnCode);
            this.panel2.Controls.Add(this.mBtnCancel);
            this.panel2.Controls.Add(this.mBtnSaveUpdate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbGroup);
            this.panel2.Location = new System.Drawing.Point(30, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 78);
            this.panel2.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(707, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 24);
            this.label14.TabIndex = 48;
            this.label14.Text = "Hsn Code";
            // 
            // txtHsnCode
            // 
            this.txtHsnCode.Location = new System.Drawing.Point(711, 35);
            this.txtHsnCode.Name = "txtHsnCode";
            this.txtHsnCode.Size = new System.Drawing.Size(173, 20);
            this.txtHsnCode.TabIndex = 4;
            // 
            // mBtnSaveUpdate
            // 
            this.mBtnSaveUpdate.Depth = 0;
            this.mBtnSaveUpdate.Location = new System.Drawing.Point(1036, 8);
            this.mBtnSaveUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnSaveUpdate.Name = "mBtnSaveUpdate";
            this.mBtnSaveUpdate.Primary = true;
            this.mBtnSaveUpdate.Size = new System.Drawing.Size(82, 28);
            this.mBtnSaveUpdate.TabIndex = 43;
            this.mBtnSaveUpdate.Text = "SAVE";
            this.mBtnSaveUpdate.UseVisualStyleBackColor = true;
            this.mBtnSaveUpdate.Click += new System.EventHandler(this.mBtnSaveUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(30, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1142, 33);
            this.panel3.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(404, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Product Entry";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 190);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Search Here..";
            // 
            // btnExcel
            // 
            this.btnExcel.Depth = 0;
            this.btnExcel.Location = new System.Drawing.Point(320, 187);
            this.btnExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Primary = true;
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 33;
            this.btnExcel.Text = "EXCEL";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Depth = 0;
            this.btnPDF.Location = new System.Drawing.Point(418, 188);
            this.btnPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Primary = true;
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 34;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // cmbTax
            // 
            this.cmbTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTax.FormattingEnabled = true;
            this.cmbTax.Items.AddRange(new object[] {
            "5",
            "12",
            "18"});
            this.cmbTax.Location = new System.Drawing.Point(901, 34);
            this.cmbTax.Name = "cmbTax";
            this.cmbTax.Size = new System.Drawing.Size(105, 21);
            this.cmbTax.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(897, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Gst";
            // 
            // mBtnCancel
            // 
            this.mBtnCancel.Depth = 0;
            this.mBtnCancel.Location = new System.Drawing.Point(1036, 42);
            this.mBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnCancel.Name = "mBtnCancel";
            this.mBtnCancel.Primary = true;
            this.mBtnCancel.Size = new System.Drawing.Size(82, 28);
            this.mBtnCancel.TabIndex = 45;
            this.mBtnCancel.Text = "CANCEL";
            this.mBtnCancel.UseVisualStyleBackColor = true;
            this.mBtnCancel.Click += new System.EventHandler(this.mBtnCancel_Click);
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1224, 673);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmItem";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnSaveUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHsnCode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label15;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnPDF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTax;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnCancel;
    }
}