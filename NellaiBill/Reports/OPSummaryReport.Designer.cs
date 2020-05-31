namespace NellaiBill.Reports
{
    partial class OPSummaryReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnViewData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCaseType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(23, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1214, 33);
            this.panel3.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(545, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "OP Summary Report";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(23, 112);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1214, 600);
            this.crystalReportViewer1.TabIndex = 46;
            // 
            // btnViewData
            // 
            this.btnViewData.Depth = 0;
            this.btnViewData.Location = new System.Drawing.Point(832, 66);
            this.btnViewData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnViewData.Name = "btnViewData";
            this.btnViewData.Primary = true;
            this.btnViewData.Size = new System.Drawing.Size(109, 26);
            this.btnViewData.TabIndex = 44;
            this.btnViewData.Text = "VIEW DATA";
            this.btnViewData.UseVisualStyleBackColor = true;
            this.btnViewData.Click += new System.EventHandler(this.btnViewData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "To Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy/MM/dd";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(206, 72);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(169, 20);
            this.dtpToDate.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy/MM/dd";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(26, 72);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(153, 20);
            this.dtpFromDate.TabIndex = 40;
            // 
            // cmbCaseType
            // 
            this.cmbCaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaseType.FormattingEnabled = true;
            this.cmbCaseType.Items.AddRange(new object[] {
            "All",
            "General",
            "Emergency",
            "Others"});
            this.cmbCaseType.Location = new System.Drawing.Point(582, 71);
            this.cmbCaseType.Name = "cmbCaseType";
            this.cmbCaseType.Size = new System.Drawing.Size(171, 21);
            this.cmbCaseType.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(579, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 130;
            this.label6.Text = "CaseType";
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Items.AddRange(new object[] {
            "All"});
            this.cmbDoctorName.Location = new System.Drawing.Point(398, 71);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(171, 21);
            this.cmbDoctorName.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "DoctorName";
            // 
            // OPSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 574);
            this.Controls.Add(this.cmbDoctorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCaseType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnViewData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFromDate);
            this.Name = "OPSummaryReport";
            this.Text = "OPSummaryReport";
            this.Load += new System.EventHandler(this.OPSummaryReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label8;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private MaterialSkin.Controls.MaterialRaisedButton btnViewData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox cmbCaseType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.Label label2;
    }
}