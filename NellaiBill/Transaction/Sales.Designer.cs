namespace NellaiBill.Master
{
    partial class SalesEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_total_amount_value = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rchCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.txtCustomerMobileNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtStockId = new System.Windows.Forms.TextBox();
            this.ItemNo = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtDiscPercentage = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDiscountValue = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNoDg1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountAfterDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GstPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GstValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBillType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(77, 29);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(193, 23);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
            this.cmbCustomer.Leave += new System.EventHandler(this.cmbCustomer_Leave);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(757, 8);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(76, 23);
            this.txtQty.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ItemName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Amount";
            // 
            // lbl_total_amount_value
            // 
            this.lbl_total_amount_value.AutoSize = true;
            this.lbl_total_amount_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_amount_value.ForeColor = System.Drawing.Color.Red;
            this.lbl_total_amount_value.Location = new System.Drawing.Point(243, 556);
            this.lbl_total_amount_value.Name = "lbl_total_amount_value";
            this.lbl_total_amount_value.Size = new System.Drawing.Size(36, 37);
            this.lbl_total_amount_value.TabIndex = 74;
            this.lbl_total_amount_value.Text = "0";
            // 
            // lblBatch
            // 
            this.lblBatch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.Location = new System.Drawing.Point(10, 51);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(49, 17);
            this.lblBatch.TabIndex = 17;
            this.lblBatch.Text = "Batch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mrp";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(510, 11);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(78, 23);
            this.txtPrice.TabIndex = 35;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(451, 44);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(48, 17);
            this.lblStock.TabIndex = 21;
            this.lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(512, 43);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(76, 23);
            this.txtStock.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(453, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Gst";
            // 
            // rchCustomerAddress
            // 
            this.rchCustomerAddress.Enabled = false;
            this.rchCustomerAddress.Location = new System.Drawing.Point(77, 62);
            this.rchCustomerAddress.Name = "rchCustomerAddress";
            this.rchCustomerAddress.Size = new System.Drawing.Size(193, 50);
            this.rchCustomerAddress.TabIndex = 200;
            this.rchCustomerAddress.Text = "";
            // 
            // txtCustomerMobileNo
            // 
            this.txtCustomerMobileNo.Enabled = false;
            this.txtCustomerMobileNo.Location = new System.Drawing.Point(281, 51);
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.txtCustomerMobileNo.Size = new System.Drawing.Size(195, 21);
            this.txtCustomerMobileNo.TabIndex = 201;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(276, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "Mobile No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Address";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.txtStockId);
            this.panel4.Controls.Add(this.ItemNo);
            this.panel4.Controls.Add(this.txtItemNo);
            this.panel4.Controls.Add(this.txtItem);
            this.panel4.Controls.Add(this.txtBatch);
            this.panel4.Controls.Add(this.txtTax);
            this.panel4.Controls.Add(this.txtDiscPercentage);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.txtDiscountValue);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.txtExpDate);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtStock);
            this.panel4.Controls.Add(this.lblStock);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblBatch);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtQty);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Location = new System.Drawing.Point(12, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(928, 107);
            this.panel4.TabIndex = 30;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(272, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 17);
            this.label22.TabIndex = 57;
            this.label22.Text = "StockId";
            // 
            // txtStockId
            // 
            this.txtStockId.Enabled = false;
            this.txtStockId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockId.Location = new System.Drawing.Point(339, 77);
            this.txtStockId.Name = "txtStockId";
            this.txtStockId.Size = new System.Drawing.Size(78, 23);
            this.txtStockId.TabIndex = 58;
            // 
            // ItemNo
            // 
            this.ItemNo.AutoSize = true;
            this.ItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNo.Location = new System.Drawing.Point(280, 44);
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Size = new System.Drawing.Size(58, 17);
            this.ItemNo.TabIndex = 55;
            this.ItemNo.Text = "ItemNo";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Enabled = false;
            this.txtItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo.Location = new System.Drawing.Point(339, 44);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(78, 23);
            this.txtItemNo.TabIndex = 56;
            // 
            // txtItem
            // 
            this.txtItem.Enabled = false;
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(95, 11);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(311, 23);
            this.txtItem.TabIndex = 54;
            // 
            // txtBatch
            // 
            this.txtBatch.Enabled = false;
            this.txtBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatch.Location = new System.Drawing.Point(95, 45);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(162, 23);
            this.txtBatch.TabIndex = 53;
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(512, 72);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(76, 23);
            this.txtTax.TabIndex = 52;
            // 
            // txtDiscPercentage
            // 
            this.txtDiscPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscPercentage.Location = new System.Drawing.Point(761, 43);
            this.txtDiscPercentage.Name = "txtDiscPercentage";
            this.txtDiscPercentage.Size = new System.Drawing.Size(76, 23);
            this.txtDiscPercentage.TabIndex = 38;
            this.txtDiscPercentage.Leave += new System.EventHandler(this.txtDiscPercentage_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(671, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 17);
            this.label20.TabIndex = 51;
            this.label20.Text = "Discount%";
            // 
            // txtDiscountValue
            // 
            this.txtDiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountValue.Location = new System.Drawing.Point(761, 77);
            this.txtDiscountValue.Name = "txtDiscountValue";
            this.txtDiscountValue.Size = new System.Drawing.Size(76, 23);
            this.txtDiscountValue.TabIndex = 39;
            this.txtDiscountValue.Leave += new System.EventHandler(this.txtDiscountValue_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(638, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 17);
            this.label21.TabIndex = 48;
            this.label21.Text = "Discount Value";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Enabled = false;
            this.txtExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.Location = new System.Drawing.Point(95, 74);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(162, 23);
            this.txtExpDate.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 40;
            this.label15.Text = "ExpDate";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(843, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 54);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerMobileNo);
            this.groupBox1.Controls.Add(this.rchCustomerAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(424, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 118);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemNoDg1,
            this.ItemName,
            this.Batch,
            this.ExpDate,
            this.Stock,
            this.Price,
            this.Qty,
            this.Amount,
            this.DiscPercentage,
            this.DiscValue,
            this.AmountAfterDiscount,
            this.GstPercentage,
            this.GstValue,
            this.TotalAmount,
            this.DGDelete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.Size = new System.Drawing.Size(928, 267);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Id
            // 
            this.Id.FillWeight = 46.63264F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ItemNoDg1
            // 
            this.ItemNoDg1.HeaderText = "ItemNoDg1";
            this.ItemNoDg1.Name = "ItemNoDg1";
            this.ItemNoDg1.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 253.8071F;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Batch
            // 
            this.Batch.FillWeight = 129.7703F;
            this.Batch.HeaderText = "Batch";
            this.Batch.Name = "Batch";
            this.Batch.ReadOnly = true;
            // 
            // ExpDate
            // 
            this.ExpDate.FillWeight = 75.35877F;
            this.ExpDate.HeaderText = "Exp Date";
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.FillWeight = 76.29374F;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 74.59606F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 72.75848F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.FillWeight = 96.89227F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DiscPercentage
            // 
            this.DiscPercentage.HeaderText = "D-%";
            this.DiscPercentage.Name = "DiscPercentage";
            this.DiscPercentage.ReadOnly = true;
            // 
            // DiscValue
            // 
            this.DiscValue.HeaderText = "D-Value";
            this.DiscValue.Name = "DiscValue";
            this.DiscValue.ReadOnly = true;
            // 
            // AmountAfterDiscount
            // 
            this.AmountAfterDiscount.HeaderText = "AAD";
            this.AmountAfterDiscount.Name = "AmountAfterDiscount";
            this.AmountAfterDiscount.ReadOnly = true;
            // 
            // GstPercentage
            // 
            this.GstPercentage.HeaderText = "Gst %";
            this.GstPercentage.Name = "GstPercentage";
            this.GstPercentage.ReadOnly = true;
            // 
            // GstValue
            // 
            this.GstValue.FillWeight = 76.99837F;
            this.GstValue.HeaderText = "Gst Value";
            this.GstValue.Name = "GstValue";
            this.GstValue.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // DGDelete
            // 
            this.DGDelete.HeaderText = "";
            this.DGDelete.Name = "DGDelete";
            this.DGDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(928, 30);
            this.panel3.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(408, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sales  Entry";
            // 
            // cmbBillType
            // 
            this.cmbBillType.FormattingEnabled = true;
            this.cmbBillType.Items.AddRange(new object[] {
            "Please Select",
            "IP",
            "OP",
            "NON-OP",
            "COURIER"});
            this.cmbBillType.Location = new System.Drawing.Point(288, 52);
            this.cmbBillType.Name = "cmbBillType";
            this.cmbBillType.Size = new System.Drawing.Size(118, 21);
            this.cmbBillType.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bill Type";
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "Please Select",
            "Cash",
            "Credit",
            "Online",
            "Cheque"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(125, 55);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(94, 21);
            this.cmbPaymentMode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mode of Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(272, 11);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(134, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 25);
            this.label17.TabIndex = 34;
            this.label17.Text = "InvNo";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.Red;
            this.lblInvoiceNo.Location = new System.Drawing.Point(83, 7);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(27, 29);
            this.lblInvoiceNo.TabIndex = 35;
            this.lblInvoiceNo.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblInvoiceNo);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbPaymentMode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbBillType);
            this.panel1.Location = new System.Drawing.Point(6, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 118);
            this.panel1.TabIndex = 35;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(946, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(395, 561);
            this.dataGridView2.TabIndex = 77;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(946, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(305, 20);
            this.txtSearch.TabIndex = 78;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(971, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Search Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(335, 598);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(412, 598);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(109, 23);
            this.txtBalance.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(335, 565);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "Paid";
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(412, 565);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(109, 23);
            this.txtPaid.TabIndex = 60;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 23);
            this.txtPassword.TabIndex = 82;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(610, 568);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(100, 20);
            this.txtUserPassword.TabIndex = 81;
            this.txtUserPassword.TextChanged += new System.EventHandler(this.txtUserPassword_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(527, 569);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 83;
            this.label13.Text = "Password";
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.BackColor = System.Drawing.Color.White;
            this.btnSaveBill.Enabled = false;
            this.btnSaveBill.Location = new System.Drawing.Point(783, 556);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(142, 37);
            this.btnSaveBill.TabIndex = 59;
            this.btnSaveBill.Text = "SAVE";
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // SalesEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 648);
            this.Controls.Add(this.btnSaveBill);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_total_amount_value);
            this.Controls.Add(this.label7);
            this.Name = "SalesEntry";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_total_amount_value;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCustomerMobileNo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rchCustomerAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbBillType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDiscPercentage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDiscountValue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtStockId;
        private System.Windows.Forms.Label ItemNo;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNoDg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountAfterDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GstPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn GstValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewButtonColumn DGDelete;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveBill;
    }
}