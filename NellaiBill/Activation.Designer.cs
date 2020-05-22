namespace NellaiBill
{
    partial class Activation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCheckInternetConnection = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mtxt_Key = new System.Windows.Forms.MaskedTextBox();
            this.btnValidate = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(52, 228);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(466, 26);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Internet Connection is needed for the activation";
            // 
            // btnCheckInternetConnection
            // 
            this.btnCheckInternetConnection.Depth = 0;
            this.btnCheckInternetConnection.Location = new System.Drawing.Point(524, 218);
            this.btnCheckInternetConnection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckInternetConnection.Name = "btnCheckInternetConnection";
            this.btnCheckInternetConnection.Primary = true;
            this.btnCheckInternetConnection.Size = new System.Drawing.Size(149, 36);
            this.btnCheckInternetConnection.TabIndex = 2;
            this.btnCheckInternetConnection.Text = "CHECK CONNECTION";
            this.btnCheckInternetConnection.UseVisualStyleBackColor = true;
            this.btnCheckInternetConnection.Click += new System.EventHandler(this.btnCheckInternetConnection_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(192, 297);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(114, 26);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Enter Key ";
            // 
            // mtxt_Key
            // 
            this.mtxt_Key.Location = new System.Drawing.Point(312, 303);
            this.mtxt_Key.Name = "mtxt_Key";
            this.mtxt_Key.Size = new System.Drawing.Size(215, 20);
            this.mtxt_Key.TabIndex = 4;
            // 
            // btnValidate
            // 
            this.btnValidate.Depth = 0;
            this.btnValidate.Location = new System.Drawing.Point(395, 354);
            this.btnValidate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Primary = true;
            this.btnValidate.Size = new System.Drawing.Size(132, 36);
            this.btnValidate.TabIndex = 5;
            this.btnValidate.Text = "VALIDATE";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(875, 583);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.mtxt_Key);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnCheckInternetConnection);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Activation";
            this.Text = "Activation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Activation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCheckInternetConnection;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.MaskedTextBox mtxt_Key;
        private MaterialSkin.Controls.MaterialRaisedButton btnValidate;
    }
}