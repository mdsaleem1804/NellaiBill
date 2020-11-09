namespace NellaiBill.Common
{
    partial class SystemInfo
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
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.rchSystemInformation = new System.Windows.Forms.RichTextBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.rchSystemInformation);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(792, 424);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "System Information";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // rchSystemInformation
            // 
            this.rchSystemInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchSystemInformation.Enabled = false;
            this.rchSystemInformation.Location = new System.Drawing.Point(3, 3);
            this.rchSystemInformation.Name = "rchSystemInformation";
            this.rchSystemInformation.Size = new System.Drawing.Size(786, 418);
            this.rchSystemInformation.TabIndex = 0;
            this.rchSystemInformation.Text = "";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(800, 450);
            this.TabControl1.TabIndex = 2;
            // 
            // SystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl1);
            this.Name = "SystemInfo";
            this.Text = "SystemInfo";
            this.Load += new System.EventHandler(this.SystemInfo_Load);
            this.TabPage1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.RichTextBox rchSystemInformation;
        internal System.Windows.Forms.TabControl TabControl1;
    }
}