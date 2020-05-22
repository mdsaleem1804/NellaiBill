namespace NellaiBill
{
    partial class YearEnd
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
            this.step_1 = new System.Windows.Forms.Button();
            this.step_2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // step_1
            // 
            this.step_1.Location = new System.Drawing.Point(62, 86);
            this.step_1.Name = "step_1";
            this.step_1.Size = new System.Drawing.Size(262, 42);
            this.step_1.TabIndex = 0;
            this.step_1.Text = "STEP1[RENAME SALES TABLE]";
            this.step_1.UseVisualStyleBackColor = true;
            this.step_1.Click += new System.EventHandler(this.step_1_Click);
            // 
            // step_2
            // 
            this.step_2.Location = new System.Drawing.Point(347, 86);
            this.step_2.Name = "step_2";
            this.step_2.Size = new System.Drawing.Size(262, 42);
            this.step_2.TabIndex = 1;
            this.step_2.Text = "STEP2[CREATE SALES  TABLE]";
            this.step_2.UseVisualStyleBackColor = true;
            this.step_2.Click += new System.EventHandler(this.step_2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // YearEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.step_2);
            this.Controls.Add(this.step_1);
            this.Name = "YearEnd";
            this.Text = "YearEnd";
            this.Load += new System.EventHandler(this.YearEnd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button step_1;
        private System.Windows.Forms.Button step_2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}