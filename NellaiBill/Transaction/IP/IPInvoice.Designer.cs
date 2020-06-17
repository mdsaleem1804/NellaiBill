namespace NellaiBill.Transaction.IP
{
    partial class IPInvoice
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
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbIPNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnParticularsAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParticularFees = new System.Windows.Forms.TextBox();
            this.cmbParticulars = new System.Windows.Forms.ComboBox();
            this.dgvAdvanceSummary = new System.Windows.Forms.DataGridView();
            this.lblAdv = new System.Windows.Forms.Label();
            this.dgvFinalSummary = new System.Windows.Forms.DataGridView();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLessAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalAmont = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvanceSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalSummary)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBillDate.Enabled = false;
            this.dtpBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(198, 86);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(150, 24);
            this.dtpBillDate.TabIndex = 189;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(195, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 190;
            this.label10.Text = "Date";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(34, 86);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(148, 24);
            this.txtInvoiceNo.TabIndex = 188;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 18);
            this.label14.TabIndex = 187;
            this.label14.Text = "Invoice No";
            // 
            // cmbIPNo
            // 
            this.cmbIPNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIPNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIPNo.FormattingEnabled = true;
            this.cmbIPNo.Location = new System.Drawing.Point(370, 84);
            this.cmbIPNo.Name = "cmbIPNo";
            this.cmbIPNo.Size = new System.Drawing.Size(167, 26);
            this.cmbIPNo.TabIndex = 11;
            this.cmbIPNo.SelectedIndexChanged += new System.EventHandler(this.cmbIPNo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 186;
            this.label5.Text = "IPNo";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnParticularsAdd);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtParticularFees);
            this.panel4.Controls.Add(this.cmbParticulars);
            this.panel4.Location = new System.Drawing.Point(34, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 75);
            this.panel4.TabIndex = 198;
            // 
            // btnParticularsAdd
            // 
            this.btnParticularsAdd.BackColor = System.Drawing.Color.Lime;
            this.btnParticularsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParticularsAdd.Location = new System.Drawing.Point(428, 35);
            this.btnParticularsAdd.Name = "btnParticularsAdd";
            this.btnParticularsAdd.Size = new System.Drawing.Size(51, 28);
            this.btnParticularsAdd.TabIndex = 14;
            this.btnParticularsAdd.Text = "+";
            this.btnParticularsAdd.UseVisualStyleBackColor = false;
            this.btnParticularsAdd.Click += new System.EventHandler(this.btnParticularsAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 195;
            this.label6.Text = "Particulars";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 18);
            this.label7.TabIndex = 194;
            this.label7.Text = "Fees";
            // 
            // txtParticularFees
            // 
            this.txtParticularFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticularFees.Location = new System.Drawing.Point(274, 39);
            this.txtParticularFees.Name = "txtParticularFees";
            this.txtParticularFees.Size = new System.Drawing.Size(148, 24);
            this.txtParticularFees.TabIndex = 13;
            // 
            // cmbParticulars
            // 
            this.cmbParticulars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParticulars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParticulars.FormattingEnabled = true;
            this.cmbParticulars.Items.AddRange(new object[] {
            "Monitor Charges",
            "Theatre Charges",
            "Maintanence Charges",
            "Duty Nurse Charges",
            "ICU",
            "Cath Lab",
            "New Born",
            "Labour Ward"});
            this.cmbParticulars.Location = new System.Drawing.Point(11, 43);
            this.cmbParticulars.Name = "cmbParticulars";
            this.cmbParticulars.Size = new System.Drawing.Size(245, 21);
            this.cmbParticulars.TabIndex = 12;
            // 
            // dgvAdvanceSummary
            // 
            this.dgvAdvanceSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvanceSummary.Location = new System.Drawing.Point(34, 295);
            this.dgvAdvanceSummary.Name = "dgvAdvanceSummary";
            this.dgvAdvanceSummary.Size = new System.Drawing.Size(515, 150);
            this.dgvAdvanceSummary.TabIndex = 200;
            // 
            // lblAdv
            // 
            this.lblAdv.AutoSize = true;
            this.lblAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAdv.Location = new System.Drawing.Point(43, 259);
            this.lblAdv.Name = "lblAdv";
            this.lblAdv.Size = new System.Drawing.Size(217, 18);
            this.lblAdv.TabIndex = 197;
            this.lblAdv.Text = "Advance Payment Summary";
            // 
            // dgvFinalSummary
            // 
            this.dgvFinalSummary.AllowUserToAddRows = false;
            this.dgvFinalSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinalSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Particulars,
            this.Fees});
            this.dgvFinalSummary.Location = new System.Drawing.Point(585, 66);
            this.dgvFinalSummary.Name = "dgvFinalSummary";
            this.dgvFinalSummary.Size = new System.Drawing.Size(513, 379);
            this.dgvFinalSummary.TabIndex = 203;
            this.dgvFinalSummary.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvFinalSummary_UserDeletedRow);
            // 
            // Particulars
            // 
            this.Particulars.HeaderText = "Particulars";
            this.Particulars.Name = "Particulars";
            // 
            // Fees
            // 
            this.Fees.HeaderText = "Fees";
            this.Fees.Name = "Fees";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(861, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 206;
            this.label9.Text = "Less";
            // 
            // txtLessAmount
            // 
            this.txtLessAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLessAmount.Location = new System.Drawing.Point(950, 528);
            this.txtLessAmount.Name = "txtLessAmount";
            this.txtLessAmount.Size = new System.Drawing.Size(148, 24);
            this.txtLessAmount.TabIndex = 205;
            this.txtLessAmount.Text = "0";
            this.txtLessAmount.TextChanged += new System.EventHandler(this.txtLessAmount_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(950, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 34);
            this.btnSave.TabIndex = 197;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPatientName.Location = new System.Drawing.Point(31, 125);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(52, 18);
            this.lblPatientName.TabIndex = 207;
            this.lblPatientName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAddress.Location = new System.Drawing.Point(191, 125);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(69, 18);
            this.lblAddress.TabIndex = 208;
            this.lblAddress.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(861, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 210;
            this.label8.Text = "Sub Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(950, 457);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(148, 24);
            this.txtSubTotal.TabIndex = 209;
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.Location = new System.Drawing.Point(861, 493);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(64, 18);
            this.lblAdvance.TabIndex = 212;
            this.lblAdvance.Text = "Advance";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Enabled = false;
            this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.Location = new System.Drawing.Point(950, 490);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(148, 24);
            this.txtAdvance.TabIndex = 211;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(651, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 213;
            this.label2.Text = "Total Amount";
            // 
            // lblTotalAmont
            // 
            this.lblTotalAmont.AutoSize = true;
            this.lblTotalAmont.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalAmont.Location = new System.Drawing.Point(819, 577);
            this.lblTotalAmont.Name = "lblTotalAmont";
            this.lblTotalAmont.Size = new System.Drawing.Size(25, 26);
            this.lblTotalAmont.TabIndex = 214;
            this.lblTotalAmont.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(582, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 215;
            this.label3.Text = " Payment Summary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP INVOICE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(34, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 35);
            this.panel3.TabIndex = 216;
            // 
            // IPInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 749);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalAmont);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.txtAdvance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLessAmount);
            this.Controls.Add(this.dgvFinalSummary);
            this.Controls.Add(this.lblAdv);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvAdvanceSummary);
            this.Controls.Add(this.dtpBillDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbIPNo);
            this.Controls.Add(this.label5);
            this.Name = "IPInvoice";
            this.Text = "IPInvoice";
            this.Load += new System.EventHandler(this.IPInvoice_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvanceSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinalSummary)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbIPNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnParticularsAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtParticularFees;
        private System.Windows.Forms.ComboBox cmbParticulars;
        private System.Windows.Forms.DataGridView dgvAdvanceSummary;
        private System.Windows.Forms.Label lblAdv;
        private System.Windows.Forms.DataGridView dgvFinalSummary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLessAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalAmont;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel panel3;
    }
}