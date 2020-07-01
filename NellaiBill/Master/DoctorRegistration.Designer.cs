namespace NellaiBill.Master
{
    partial class DoctorRegistration
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
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mBtnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mBtnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(12, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 33);
            this.panel3.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(372, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Doctor Registration";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1003, 243);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveUpdate);
            this.groupBox1.Controls.Add(this.mBtnCancel);
            this.groupBox1.Controls.Add(this.mBtnDelete);
            this.groupBox1.Controls.Add(this.cmbSpecialization);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMobileNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rchAddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbGender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(33, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 206);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            // 
            // mBtnCancel
            // 
            this.mBtnCancel.Depth = 0;
            this.mBtnCancel.Location = new System.Drawing.Point(582, 134);
            this.mBtnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnCancel.Name = "mBtnCancel";
            this.mBtnCancel.Primary = true;
            this.mBtnCancel.Size = new System.Drawing.Size(82, 28);
            this.mBtnCancel.TabIndex = 48;
            this.mBtnCancel.Text = "CANCEL";
            this.mBtnCancel.UseVisualStyleBackColor = true;
            // 
            // mBtnDelete
            // 
            this.mBtnDelete.Depth = 0;
            this.mBtnDelete.Location = new System.Drawing.Point(485, 134);
            this.mBtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtnDelete.Name = "mBtnDelete";
            this.mBtnDelete.Primary = true;
            this.mBtnDelete.Size = new System.Drawing.Size(82, 28);
            this.mBtnDelete.TabIndex = 47;
            this.mBtnDelete.Text = "DELETE";
            this.mBtnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Items.AddRange(new object[] {
            "General Medicine",
            "Other",
            "Radiologist"});
            this.cmbSpecialization.Location = new System.Drawing.Point(509, 24);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(160, 21);
            this.cmbSpecialization.TabIndex = 32;
            this.cmbSpecialization.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Specialization";
            this.label1.Visible = false;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(90, 75);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(254, 20);
            this.txtMobileNo.TabIndex = 7;
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mobile No";
            // 
            // rchAddress
            // 
            this.rchAddress.Location = new System.Drawing.Point(90, 112);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(254, 77);
            this.rchAddress.TabIndex = 6;
            this.rchAddress.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Address";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(509, 78);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(160, 21);
            this.cmbGender.TabIndex = 4;
            this.cmbGender.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gender";
            this.label5.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(86, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(255, 20);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name";
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveUpdate.Location = new System.Drawing.Point(377, 127);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(92, 57);
            this.btnSaveUpdate.TabIndex = 137;
            this.btnSaveUpdate.Text = "SAVE";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // DoctorRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 638);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "DoctorRegistration";
            this.Text = "DoctorRegistration";
            this.Load += new System.EventHandler(this.DoctorRegistration_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton mBtnDelete;
        private System.Windows.Forms.Button btnSaveUpdate;
    }
}