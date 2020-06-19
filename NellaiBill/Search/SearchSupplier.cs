using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Master
{
    public partial class SearchSupplier : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();

        public string xSupplierNo { get; set; }
        public string xSupplierName { get; set; }
        public string xSupplierMobileNo { get; set; }
        public string xSupplierAddress { get; set; }

        private int _formType = 0;
        public SearchSupplier(int xFormType)
        {
            InitializeComponent();
            _formType = xFormType;
        }

        private void SearchLedger_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //refer key activities
            xSupplierNo = "0";
            txtSearch.Select();
            xDb.LoadGrid("select supplier_id,name,mobile_no, address from m_supplier order by name", dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].FillWeight = 200;
            dataGridView1.Columns[3].FillWeight = 60;
        }
        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "name Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                DataGridViewRow dgr = dataGridView1.CurrentRow;
                xSupplierNo = dgr.Cells[0].Value.ToString();
                xSupplierName = dgr.Cells[1].Value.ToString();
                if (xSupplierName == "")
                {
                    MessageBox.Show("Please select different Customer");
                    return;
                }
                xSupplierMobileNo = dgr.Cells[2].Value.ToString();
                xSupplierAddress = dgr.Cells[3].Value.ToString();
                this.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xSupplierNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            xSupplierName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (xSupplierName == "")
            {
                MessageBox.Show("Please select different Customer");
                return;
            }
            xSupplierMobileNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            xSupplierAddress = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.Close();
        }

        private void SearchLedger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
