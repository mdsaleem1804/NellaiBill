namespace NellaiBill.Transaction.IP
{
    partial class IPAdmission
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
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUhid = new System.Windows.Forms.TextBox();
            this.txtLabId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPatientId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCaseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Items.AddRange(new object[] {
            "All"});
            this.cmbDoctor.Location = new System.Drawing.Point(29, 42);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(183, 26);
            this.cmbDoctor.TabIndex = 166;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 167;
            this.label5.Text = "DoctorName";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(41, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1236, 35);
            this.panel3.TabIndex = 165;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(454, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "IP NEW ADMISSION";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtUhid);
            this.panel1.Controls.Add(this.txtLabId);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtPatientId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPatientSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Controls.Add(this.dtpBillDate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(41, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 73);
            this.panel1.TabIndex = 164;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(592, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 18);
            this.label15.TabIndex = 169;
            this.label15.Text = "UHID";
            // 
            // txtUhid
            // 
            this.txtUhid.Enabled = false;
            this.txtUhid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUhid.Location = new System.Drawing.Point(595, 35);
            this.txtUhid.Name = "txtUhid";
            this.txtUhid.Size = new System.Drawing.Size(146, 24);
            this.txtUhid.TabIndex = 168;
            // 
            // txtLabId
            // 
            this.txtLabId.Enabled = false;
            this.txtLabId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabId.Location = new System.Drawing.Point(29, 35);
            this.txtLabId.Name = "txtLabId";
            this.txtLabId.Size = new System.Drawing.Size(183, 24);
            this.txtLabId.TabIndex = 131;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 18);
            this.label14.TabIndex = 130;
            this.label14.Text = "IPNo";
            // 
            // txtPatientId
            // 
            this.txtPatientId.Enabled = false;
            this.txtPatientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientId.Location = new System.Drawing.Point(441, 35);
            this.txtPatientId.Name = "txtPatientId";
            this.txtPatientId.Size = new System.Drawing.Size(146, 24);
            this.txtPatientId.TabIndex = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 126;
            this.label4.Text = "Patient Id";
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.Lime;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.Location = new System.Drawing.Point(1036, 3);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(121, 54);
            this.btnPatientSearch.TabIndex = 125;
            this.btnPatientSearch.Text = "SEARCH (CTRL+P)";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 124;
            this.label2.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(749, 35);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(268, 24);
            this.txtPatientName.TabIndex = 123;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBillDate.Enabled = false;
            this.dtpBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(235, 35);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(183, 24);
            this.dtpBillDate.TabIndex = 121;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 122;
            this.label10.Text = "Date";
            // 
            // cmbCaseType
            // 
            this.cmbCaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaseType.FormattingEnabled = true;
            this.cmbCaseType.Items.AddRange(new object[] {
            "All"});
            this.cmbCaseType.Location = new System.Drawing.Point(235, 42);
            this.cmbCaseType.Name = "cmbCaseType";
            this.cmbCaseType.Size = new System.Drawing.Size(183, 26);
            this.cmbCaseType.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 169;
            this.label1.Text = "Case";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Items.AddRange(new object[] {
            "All"});
            this.cmbRoom.Location = new System.Drawing.Point(432, 42);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(183, 26);
            this.cmbRoom.TabIndex = 170;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 171;
            this.label3.Text = "Room";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(637, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 24);
            this.textBox1.TabIndex = 173;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(634, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 172;
            this.label6.Text = "Admitted By";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(835, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 54);
            this.button1.TabIndex = 170;
            this.button1.Text = "SAVE (CTRL+S)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1236, 287);
            this.dataGridView1.TabIndex = 174;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbRoom);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbCaseType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbDoctor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(41, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 78);
            this.panel2.TabIndex = 175;
            // 
            // IPAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "IPAdmission";
            this.Text = "IPAdmission";
            this.Load += new System.EventHandler(this.IPAdmission_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLabId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUhid;
        private System.Windows.Forms.ComboBox cmbCaseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
    }
}