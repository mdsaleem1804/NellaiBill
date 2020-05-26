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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.rchItemDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscPercentage = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGst = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelOpeningStock = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOpeningStock = new System.Windows.Forms.TextBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHsnCode = new System.Windows.Forms.TextBox();
            this.mBtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mBtnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mBtnSaveUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnExcel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPDF = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelOpeningStock.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(148, 20);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(173, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 347);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 294);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(148, 97);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(173, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Item Name";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(148, 61);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(173, 21);
            this.cmbGroup.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Group";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(190, 48);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(101, 20);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBarCode);
            this.panel1.Controls.Add(this.rchItemDescription);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtDiscValue);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDiscPercentage);
            this.panel1.Location = new System.Drawing.Point(764, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 176);
            this.panel1.TabIndex = 28;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Item Description";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(269, 25);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(87, 20);
            this.txtBarCode.TabIndex = 40;
            // 
            // rchItemDescription
            // 
            this.rchItemDescription.AcceptsTab = true;
            this.rchItemDescription.Location = new System.Drawing.Point(134, 106);
            this.rchItemDescription.Name = "rchItemDescription";
            this.rchItemDescription.Size = new System.Drawing.Size(139, 43);
            this.rchItemDescription.TabIndex = 31;
            this.rchItemDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "BarCode";
            // 
            // txtDiscValue
            // 
            this.txtDiscValue.Location = new System.Drawing.Point(243, 59);
            this.txtDiscValue.Name = "txtDiscValue";
            this.txtDiscValue.Size = new System.Drawing.Size(60, 20);
            this.txtDiscValue.TabIndex = 38;
            this.txtDiscValue.Leave += new System.EventHandler(this.txtDiscValue_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Disc Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Disc %";
            // 
            // txtDiscPercentage
            // 
            this.txtDiscPercentage.Location = new System.Drawing.Point(67, 59);
            this.txtDiscPercentage.Name = "txtDiscPercentage";
            this.txtDiscPercentage.Size = new System.Drawing.Size(60, 20);
            this.txtDiscPercentage.TabIndex = 36;
            this.txtDiscPercentage.Leave += new System.EventHandler(this.txtDiscPercentage_Leave);
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "Pcs"});
            this.cmbUnit.Location = new System.Drawing.Point(597, 61);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(101, 21);
            this.cmbUnit.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Unit";
            // 
            // cmbGst
            // 
            this.cmbGst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGst.FormattingEnabled = true;
            this.cmbGst.Items.AddRange(new object[] {
            "5",
            "12",
            "18"});
            this.cmbGst.Location = new System.Drawing.Point(597, 16);
            this.cmbGst.Name = "cmbGst";
            this.cmbGst.Size = new System.Drawing.Size(101, 21);
            this.cmbGst.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Gst";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelOpeningStock);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtHsnCode);
            this.panel2.Controls.Add(this.cmbUnit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.mBtnCancel);
            this.panel2.Controls.Add(this.mBtnDelete);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.mBtnSaveUpdate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtItemName);
            this.panel2.Controls.Add(this.cmbGst);
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbGroup);
            this.panel2.Location = new System.Drawing.Point(30, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 231);
            this.panel2.TabIndex = 29;
            // 
            // panelOpeningStock
            // 
            this.panelOpeningStock.Controls.Add(this.label12);
            this.panelOpeningStock.Controls.Add(this.txtOpeningStock);
            this.panelOpeningStock.Controls.Add(this.txtPrice);
            this.panelOpeningStock.Controls.Add(this.dtpExpDate);
            this.panelOpeningStock.Controls.Add(this.label5);
            this.panelOpeningStock.Controls.Add(this.label13);
            this.panelOpeningStock.Location = new System.Drawing.Point(407, 97);
            this.panelOpeningStock.Name = "panelOpeningStock";
            this.panelOpeningStock.Size = new System.Drawing.Size(297, 117);
            this.panelOpeningStock.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 25);
            this.label12.TabIndex = 42;
            this.label12.Text = "Opening Stock";
            // 
            // txtOpeningStock
            // 
            this.txtOpeningStock.Location = new System.Drawing.Point(190, 18);
            this.txtOpeningStock.Name = "txtOpeningStock";
            this.txtOpeningStock.Size = new System.Drawing.Size(101, 20);
            this.txtOpeningStock.TabIndex = 13;
            this.txtOpeningStock.Text = "0";
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(190, 88);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(101, 20);
            this.dtpExpDate.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 46;
            this.label13.Text = "ExpDate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 24);
            this.label14.TabIndex = 48;
            this.label14.Text = "Hsn Code";
            // 
            // txtHsnCode
            // 
            this.txtHsnCode.Location = new System.Drawing.Point(148, 135);
            this.txtHsnCode.Name = "txtHsnCode";
            this.txtHsnCode.Size = new System.Drawing.Size(173, 20);
            this.txtHsnCode.TabIndex = 4;
            // 
            // mBtnCancel
            // 
            this.mBtnCancel.Depth = 0;
            this.mBtnCancel.Location = new System.Drawing.Point(301, 199);
            this.mBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnCancel.Name = "mBtnCancel";
            this.mBtnCancel.Primary = true;
            this.mBtnCancel.Size = new System.Drawing.Size(82, 28);
            this.mBtnCancel.TabIndex = 45;
            this.mBtnCancel.Text = "CANCEL";
            this.mBtnCancel.UseVisualStyleBackColor = true;
            this.mBtnCancel.Click += new System.EventHandler(this.mBtnCancel_Click);
            // 
            // mBtnDelete
            // 
            this.mBtnDelete.Depth = 0;
            this.mBtnDelete.Location = new System.Drawing.Point(204, 199);
            this.mBtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnDelete.Name = "mBtnDelete";
            this.mBtnDelete.Primary = true;
            this.mBtnDelete.Size = new System.Drawing.Size(82, 28);
            this.mBtnDelete.TabIndex = 44;
            this.mBtnDelete.Text = "DELETE";
            this.mBtnDelete.UseVisualStyleBackColor = true;
            this.mBtnDelete.Click += new System.EventHandler(this.mBtnDelete_Click);
            // 
            // mBtnSaveUpdate
            // 
            this.mBtnSaveUpdate.Depth = 0;
            this.mBtnSaveUpdate.Location = new System.Drawing.Point(115, 199);
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
            this.txtSearch.Location = new System.Drawing.Point(117, 313);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Search Here..";
            // 
            // btnExcel
            // 
            this.btnExcel.Depth = 0;
            this.btnExcel.Location = new System.Drawing.Point(320, 310);
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
            this.btnPDF.Location = new System.Drawing.Point(418, 311);
            this.btnPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Primary = true;
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 34;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelOpeningStock.ResumeLayout(false);
            this.panelOpeningStock.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGst;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOpeningStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchItemDescription;
        private System.Windows.Forms.TextBox txtDiscValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiscPercentage;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnSaveUpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHsnCode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label15;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnPDF;
        private System.Windows.Forms.Panel panelOpeningStock;
    }
}