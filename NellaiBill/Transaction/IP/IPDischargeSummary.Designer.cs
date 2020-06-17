namespace NellaiBill.Transaction.IP
{
    partial class IPDischargeSummary
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
            this.txtDischargeNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbIPNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rchAdmissionCondition = new System.Windows.Forms.RichTextBox();
            this.rchInvestigationDone = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rchTreatmentGiven = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.rchClinicalCourse = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rchDischargeCondition = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rchDischargeAdvice = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFolllowUpVisit = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCaseType = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "yyyy-MM-dd";
            this.dtpBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(330, 41);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(251, 24);
            this.dtpBillDate.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(327, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 18);
            this.label10.TabIndex = 214;
            this.label10.Text = "Date";
            // 
            // txtDischargeNo
            // 
            this.txtDischargeNo.Enabled = false;
            this.txtDischargeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDischargeNo.Location = new System.Drawing.Point(610, 41);
            this.txtDischargeNo.Name = "txtDischargeNo";
            this.txtDischargeNo.Size = new System.Drawing.Size(251, 24);
            this.txtDischargeNo.TabIndex = 212;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(607, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 18);
            this.label14.TabIndex = 211;
            this.label14.Text = "Discharge No";
            // 
            // cmbIPNo
            // 
            this.cmbIPNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIPNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIPNo.FormattingEnabled = true;
            this.cmbIPNo.Location = new System.Drawing.Point(6, 39);
            this.cmbIPNo.Name = "cmbIPNo";
            this.cmbIPNo.Size = new System.Drawing.Size(254, 26);
            this.cmbIPNo.TabIndex = 1;
            this.cmbIPNo.SelectedIndexChanged += new System.EventHandler(this.cmbIPNo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 210;
            this.label5.Text = "IPNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP DISCHARGE SUMMARY";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(39, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1116, 35);
            this.panel3.TabIndex = 217;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 219;
            this.label2.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(6, 106);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(254, 24);
            this.txtPatientName.TabIndex = 218;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 221;
            this.label3.Text = "Condition on Admission";
            // 
            // rchAdmissionCondition
            // 
            this.rchAdmissionCondition.Location = new System.Drawing.Point(39, 218);
            this.rchAdmissionCondition.Name = "rchAdmissionCondition";
            this.rchAdmissionCondition.Size = new System.Drawing.Size(260, 76);
            this.rchAdmissionCondition.TabIndex = 11;
            this.rchAdmissionCondition.Text = "";
            // 
            // rchInvestigationDone
            // 
            this.rchInvestigationDone.Location = new System.Drawing.Point(348, 218);
            this.rchInvestigationDone.Name = "rchInvestigationDone";
            this.rchInvestigationDone.Size = new System.Drawing.Size(251, 76);
            this.rchInvestigationDone.TabIndex = 12;
            this.rchInvestigationDone.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 223;
            this.label4.Text = "Investigation Done";
            // 
            // rchTreatmentGiven
            // 
            this.rchTreatmentGiven.Location = new System.Drawing.Point(628, 218);
            this.rchTreatmentGiven.Name = "rchTreatmentGiven";
            this.rchTreatmentGiven.Size = new System.Drawing.Size(251, 76);
            this.rchTreatmentGiven.TabIndex = 13;
            this.rchTreatmentGiven.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 18);
            this.label6.TabIndex = 225;
            this.label6.Text = "Treatment Given";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 228;
            this.label7.Text = "Doctor Name";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Enabled = false;
            this.txtDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(330, 104);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(251, 24);
            this.txtDoctorName.TabIndex = 227;
            // 
            // rchClinicalCourse
            // 
            this.rchClinicalCourse.Location = new System.Drawing.Point(912, 218);
            this.rchClinicalCourse.Name = "rchClinicalCourse";
            this.rchClinicalCourse.Size = new System.Drawing.Size(243, 76);
            this.rchClinicalCourse.TabIndex = 14;
            this.rchClinicalCourse.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(908, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 18);
            this.label8.TabIndex = 229;
            this.label8.Text = "Clinical Course While In the Hospital";
            // 
            // rchDischargeCondition
            // 
            this.rchDischargeCondition.Location = new System.Drawing.Point(39, 334);
            this.rchDischargeCondition.Name = "rchDischargeCondition";
            this.rchDischargeCondition.Size = new System.Drawing.Size(260, 76);
            this.rchDischargeCondition.TabIndex = 15;
            this.rchDischargeCondition.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 18);
            this.label9.TabIndex = 231;
            this.label9.Text = "Condition on Discharge";
            // 
            // rchDischargeAdvice
            // 
            this.rchDischargeAdvice.Location = new System.Drawing.Point(348, 334);
            this.rchDischargeAdvice.Name = "rchDischargeAdvice";
            this.rchDischargeAdvice.Size = new System.Drawing.Size(251, 76);
            this.rchDischargeAdvice.TabIndex = 16;
            this.rchDischargeAdvice.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(345, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 233;
            this.label11.Text = "Discharge Advice";
            // 
            // dtpFolllowUpVisit
            // 
            this.dtpFolllowUpVisit.CustomFormat = "yyyy-MM-dd";
            this.dtpFolllowUpVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFolllowUpVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFolllowUpVisit.Location = new System.Drawing.Point(628, 334);
            this.dtpFolllowUpVisit.Name = "dtpFolllowUpVisit";
            this.dtpFolllowUpVisit.Size = new System.Drawing.Size(150, 24);
            this.dtpFolllowUpVisit.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(625, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 18);
            this.label12.TabIndex = 236;
            this.label12.Text = "Follow Up Visit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(607, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 18);
            this.label13.TabIndex = 238;
            this.label13.Text = "Case Type";
            // 
            // txtCaseType
            // 
            this.txtCaseType.Enabled = false;
            this.txtCaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaseType.Location = new System.Drawing.Point(610, 104);
            this.txtCaseType.Name = "txtCaseType";
            this.txtCaseType.Size = new System.Drawing.Size(251, 24);
            this.txtCaseType.TabIndex = 237;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Lime;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(904, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 53);
            this.btnEdit.TabIndex = 239;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Lime;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(904, 69);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 53);
            this.btnPrint.TabIndex = 240;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1116, 235);
            this.dataGridView1.TabIndex = 241;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtCaseType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDoctorName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Controls.Add(this.dtpBillDate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtDischargeNo);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cmbIPNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(39, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 133);
            this.panel1.TabIndex = 242;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUpdate.Location = new System.Drawing.Point(628, 364);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(150, 46);
            this.btnSaveUpdate.TabIndex = 241;
            this.btnSaveUpdate.Text = "SAVE";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // IPDischargeSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 719);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFolllowUpVisit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rchDischargeAdvice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rchDischargeCondition);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rchClinicalCourse);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rchTreatmentGiven);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rchInvestigationDone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rchAdmissionCondition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Name = "IPDischargeSummary";
            this.Text = "IPDischargeSummary";
            this.Load += new System.EventHandler(this.IPDischargeSummary_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IPDischargeSummary_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDischargeNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbIPNo;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rchAdmissionCondition;
        private System.Windows.Forms.RichTextBox rchInvestigationDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchTreatmentGiven;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.RichTextBox rchClinicalCourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rchDischargeCondition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rchDischargeAdvice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFolllowUpVisit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCaseType;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveUpdate;
    }
}