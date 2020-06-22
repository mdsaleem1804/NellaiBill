namespace NellaiBill.Master
{
    partial class StockAdjustment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 281);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(116, 49);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(190, 20);
            this.txtItemName.TabIndex = 8;
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(349, 79);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(105, 39);
            this.btnSaveUpdate.TabIndex = 9;
            this.btnSaveUpdate.Text = "UPDATE";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(460, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 39);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(420, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 20);
            this.txtPrice.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(723, 46);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(190, 20);
            this.txtStock.TabIndex = 16;
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(116, 89);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(190, 20);
            this.txtBatch.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Batch";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(12, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1143, 33);
            this.panel3.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(404, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Stock Adjustment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Search Item";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(97, 132);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 20);
            this.txtSearch.TabIndex = 83;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // StockAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1305, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSaveUpdate);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label1);
            this.Name = "StockAdjustment";
            this.Text = "SetPrice";
            this.Load += new System.EventHandler(this.SetPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
    }
}