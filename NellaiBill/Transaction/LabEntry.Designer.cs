namespace NellaiBill.Master
{
    partial class LabEntry
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnViewLabEntry = new System.Windows.Forms.Button();
            this.txtLabId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLabEntryUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 380);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnViewLabEntry
            // 
            this.btnViewLabEntry.Location = new System.Drawing.Point(215, 29);
            this.btnViewLabEntry.Name = "btnViewLabEntry";
            this.btnViewLabEntry.Size = new System.Drawing.Size(121, 23);
            this.btnViewLabEntry.TabIndex = 9;
            this.btnViewLabEntry.Text = "VIEW";
            this.btnViewLabEntry.UseVisualStyleBackColor = true;
            this.btnViewLabEntry.Click += new System.EventHandler(this.btnViewLabEntry_Click);
            // 
            // txtLabId
            // 
            this.txtLabId.Location = new System.Drawing.Point(88, 32);
            this.txtLabId.Name = "txtLabId";
            this.txtLabId.Size = new System.Drawing.Size(121, 20);
            this.txtLabId.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lab Id";
            // 
            // btnLabEntryUpdate
            // 
            this.btnLabEntryUpdate.Location = new System.Drawing.Point(215, 67);
            this.btnLabEntryUpdate.Name = "btnLabEntryUpdate";
            this.btnLabEntryUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnLabEntryUpdate.TabIndex = 11;
            this.btnLabEntryUpdate.Text = "UPDATE";
            this.btnLabEntryUpdate.UseVisualStyleBackColor = true;
            this.btnLabEntryUpdate.Click += new System.EventHandler(this.btnLabEntryUpdate_Click);
            // 
            // LabEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 478);
            this.Controls.Add(this.btnLabEntryUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnViewLabEntry);
            this.Controls.Add(this.txtLabId);
            this.Controls.Add(this.label1);
            this.Name = "LabEntry";
            this.Text = "LabEntry";
            this.Load += new System.EventHandler(this.LabEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnViewLabEntry;
        private System.Windows.Forms.TextBox txtLabId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLabEntryUpdate;
    }
}