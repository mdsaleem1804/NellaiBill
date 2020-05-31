namespace NellaiBill.Transaction
{
    partial class NewPatient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUhid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbUhidSelection = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtUhid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPatientId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMobileNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rchAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDob);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1235, 193);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(1080, 40);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(104, 20);
            this.txtAge.TabIndex = 63;
            this.txtAge.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1077, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Age";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(235, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 46);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "SAVE(CTRL+S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUhid
            // 
            this.txtUhid.Enabled = false;
            this.txtUhid.Location = new System.Drawing.Point(155, 40);
            this.txtUhid.Name = "txtUhid";
            this.txtUhid.Size = new System.Drawing.Size(104, 20);
            this.txtUhid.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "UHID";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Enabled = false;
            this.txtPatientId.Location = new System.Drawing.Point(20, 40);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(109, 20);
            this.txtPatientId.TabIndex = 11;
            this.txtPatientId.TextChanged += new System.EventHandler(this.txtPatientId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Patient Id";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(520, 40);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(160, 20);
            this.txtMobileNo.TabIndex = 14;
            this.txtMobileNo.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mobile No";
            // 
            // rchAddress
            // 
            this.rchAddress.Location = new System.Drawing.Point(20, 96);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(199, 77);
            this.rchAddress.TabIndex = 17;
            this.rchAddress.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Address";
            // 
            // dtpDob
            // 
            this.dtpDob.CustomFormat = "yyyy-MM-dd";
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(899, 41);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(160, 20);
            this.dtpDob.TabIndex = 16;
            this.dtpDob.Leave += new System.EventHandler(this.dtpDob_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "D.O.B";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(717, 40);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(160, 21);
            this.cmbGender.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(714, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(278, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 20);
            this.txtName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1235, 355);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmbUhidSelection
            // 
            this.cmbUhidSelection.FormattingEnabled = true;
            this.cmbUhidSelection.Items.AddRange(new object[] {
            "NEW",
            "OLD"});
            this.cmbUhidSelection.Location = new System.Drawing.Point(32, 12);
            this.cmbUhidSelection.Name = "cmbUhidSelection";
            this.cmbUhidSelection.Size = new System.Drawing.Size(121, 21);
            this.cmbUhidSelection.TabIndex = 29;
            this.cmbUhidSelection.SelectedIndexChanged += new System.EventHandler(this.cmbUhidSelection_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Search Patient";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(128, 258);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 20);
            this.txtSearch.TabIndex = 90;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 520);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbUhidSelection);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewPatient";
            this.Text = "NewPatient";
            this.Load += new System.EventHandler(this.NewPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUhid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUhidSelection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
    }
}