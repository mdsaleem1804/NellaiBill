namespace NellaiBill.Transaction
{
    partial class frmPurchaseReturn
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnView_Date = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.btnView_Supplier = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.btnView_Item = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPurchaseInvoiceNo = new System.Windows.Forms.TextBox();
            this.btnView_Invoice = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDebitNoteNo = new System.Windows.Forms.TextBox();
            this.mbtnPurchaseReturn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rchRemarks = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChangeQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOldQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 33);
            this.panel3.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(399, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Purchase Return";
            // 
            // btnView_Date
            // 
            this.btnView_Date.Depth = 0;
            this.btnView_Date.Location = new System.Drawing.Point(9, 82);
            this.btnView_Date.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnView_Date.Name = "btnView_Date";
            this.btnView_Date.Primary = true;
            this.btnView_Date.Size = new System.Drawing.Size(179, 26);
            this.btnView_Date.TabIndex = 45;
            this.btnView_Date.Text = "VIEW DATA";
            this.btnView_Date.UseVisualStyleBackColor = true;
            this.btnView_Date.Click += new System.EventHandler(this.btnView_Date_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "To Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy/MM/dd";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(85, 56);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(103, 20);
            this.dtpToDate.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy/MM/dd";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(85, 28);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(103, 20);
            this.dtpFromDate.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnView_Date);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Location = new System.Drawing.Point(31, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 123);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Wise";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSupplier);
            this.groupBox2.Controls.Add(this.btnView_Supplier);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(243, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 123);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supplier";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(9, 48);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(153, 21);
            this.cmbSupplier.TabIndex = 46;
            // 
            // btnView_Supplier
            // 
            this.btnView_Supplier.Depth = 0;
            this.btnView_Supplier.Location = new System.Drawing.Point(9, 82);
            this.btnView_Supplier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnView_Supplier.Name = "btnView_Supplier";
            this.btnView_Supplier.Primary = true;
            this.btnView_Supplier.Size = new System.Drawing.Size(153, 26);
            this.btnView_Supplier.TabIndex = 45;
            this.btnView_Supplier.Text = "VIEW DATA";
            this.btnView_Supplier.UseVisualStyleBackColor = true;
            this.btnView_Supplier.Click += new System.EventHandler(this.btnView_Supplier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Choose Supplier Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbItem);
            this.groupBox3.Controls.Add(this.btnView_Item);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(427, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 123);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item";
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(9, 48);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(153, 21);
            this.cmbItem.TabIndex = 46;
            // 
            // btnView_Item
            // 
            this.btnView_Item.Depth = 0;
            this.btnView_Item.Location = new System.Drawing.Point(9, 82);
            this.btnView_Item.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnView_Item.Name = "btnView_Item";
            this.btnView_Item.Primary = true;
            this.btnView_Item.Size = new System.Drawing.Size(153, 26);
            this.btnView_Item.TabIndex = 45;
            this.btnView_Item.Text = "VIEW DATA";
            this.btnView_Item.UseVisualStyleBackColor = true;
            this.btnView_Item.Click += new System.EventHandler(this.btnView_Item_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Choose Item Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPurchaseInvoiceNo);
            this.groupBox4.Controls.Add(this.btnView_Invoice);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(611, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 123);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Invoice";
            // 
            // txtPurchaseInvoiceNo
            // 
            this.txtPurchaseInvoiceNo.Location = new System.Drawing.Point(9, 48);
            this.txtPurchaseInvoiceNo.Name = "txtPurchaseInvoiceNo";
            this.txtPurchaseInvoiceNo.Size = new System.Drawing.Size(153, 20);
            this.txtPurchaseInvoiceNo.TabIndex = 46;
            // 
            // btnView_Invoice
            // 
            this.btnView_Invoice.Depth = 0;
            this.btnView_Invoice.Location = new System.Drawing.Point(9, 82);
            this.btnView_Invoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnView_Invoice.Name = "btnView_Invoice";
            this.btnView_Invoice.Primary = true;
            this.btnView_Invoice.Size = new System.Drawing.Size(153, 26);
            this.btnView_Invoice.TabIndex = 45;
            this.btnView_Invoice.Text = "VIEW DATA";
            this.btnView_Invoice.UseVisualStyleBackColor = true;
            this.btnView_Invoice.Click += new System.EventHandler(this.btnView_Invoice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Enter Purchase Invoice No ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 230);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtDebitNoteNo
            // 
            this.txtDebitNoteNo.Location = new System.Drawing.Point(98, 18);
            this.txtDebitNoteNo.Name = "txtDebitNoteNo";
            this.txtDebitNoteNo.ReadOnly = true;
            this.txtDebitNoteNo.Size = new System.Drawing.Size(56, 20);
            this.txtDebitNoteNo.TabIndex = 51;
            // 
            // mbtnPurchaseReturn
            // 
            this.mbtnPurchaseReturn.Depth = 0;
            this.mbtnPurchaseReturn.Location = new System.Drawing.Point(630, 15);
            this.mbtnPurchaseReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPurchaseReturn.Name = "mbtnPurchaseReturn";
            this.mbtnPurchaseReturn.Primary = true;
            this.mbtnPurchaseReturn.Size = new System.Drawing.Size(86, 74);
            this.mbtnPurchaseReturn.TabIndex = 57;
            this.mbtnPurchaseReturn.Text = "PURCHASE RETURN";
            this.mbtnPurchaseReturn.UseVisualStyleBackColor = true;
            this.mbtnPurchaseReturn.Click += new System.EventHandler(this.mbtnPurchaseReturn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Debit Note No";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtItemNo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtBatch);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.rchRemarks);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtChangeQty);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtOldQty);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mbtnPurchaseReturn);
            this.panel1.Controls.Add(this.txtDebitNoteNo);
            this.panel1.Location = new System.Drawing.Point(31, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 137);
            this.panel1.TabIndex = 51;
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(331, 19);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(104, 20);
            this.txtBatch.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Batch";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(98, 76);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(137, 20);
            this.txtItemName.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Item Name";
            // 
            // rchRemarks
            // 
            this.rchRemarks.Location = new System.Drawing.Point(457, 35);
            this.rchRemarks.Name = "rchRemarks";
            this.rchRemarks.Size = new System.Drawing.Size(161, 65);
            this.rchRemarks.TabIndex = 56;
            this.rchRemarks.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Narration";
            // 
            // txtChangeQty
            // 
            this.txtChangeQty.Location = new System.Drawing.Point(346, 85);
            this.txtChangeQty.Name = "txtChangeQty";
            this.txtChangeQty.Size = new System.Drawing.Size(89, 20);
            this.txtChangeQty.TabIndex = 55;
            this.txtChangeQty.Leave += new System.EventHandler(this.txtChangeQty_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Change Qty";
            // 
            // txtOldQty
            // 
            this.txtOldQty.Location = new System.Drawing.Point(346, 49);
            this.txtOldQty.Name = "txtOldQty";
            this.txtOldQty.ReadOnly = true;
            this.txtOldQty.Size = new System.Drawing.Size(89, 20);
            this.txtOldQty.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Old Qty";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Location = new System.Drawing.Point(98, 46);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.ReadOnly = true;
            this.txtItemNo.Size = new System.Drawing.Size(56, 20);
            this.txtItemNo.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Item No";
            // 
            // frmPurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(804, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "frmPurchaseReturn";
            this.Text = "frmPurchaseReturn";
            this.Load += new System.EventHandler(this.frmPurchaseReturn_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialRaisedButton btnView_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnView_Supplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbItem;
        private MaterialSkin.Controls.MaterialRaisedButton btnView_Item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPurchaseInvoiceNo;
        private MaterialSkin.Controls.MaterialRaisedButton btnView_Invoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDebitNoteNo;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnPurchaseReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOldQty;
        private System.Windows.Forms.TextBox txtChangeQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rchRemarks;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label13;
    }
}