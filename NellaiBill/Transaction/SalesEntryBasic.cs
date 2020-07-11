using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Transaction
{
    public partial class SalesEntryBasic : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public SalesEntryBasic()
        {
            InitializeComponent();
        }

        private void SalesEntryBasic_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[1].Width = 300;
            DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["ProductName"];
            xDb.LoadComboBoxCell("select product_name from m_product", cbCell);
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells["ProductName"];
            //xDb.LoadComboBoxCell("select product_name from m_product", cbCell);

        }
    }
}
