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
    public partial class SearchLedger : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();

        public string xLedgerNo { get; set; }
        public string xLedgerName { get; set; }
        public string xLedgerMobileNo { get; set; }
        public string xLedgerAddress { get; set; }

        private int _formType = 0;
        public SearchLedger(int xFormType)
        {
            InitializeComponent();
            _formType = xFormType;
        }

        private void SearchLedger_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //refer key activities
            xLedgerNo = "0";
            txtSearch.Select();
            xDb.LoadGrid("select account_ledger_id,ledger_name,ledger_mobile_no, ledger_address from account_ledger " +
                " where ledger_undergroup_no="+ _formType + "  order by ledger_name", dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].FillWeight = 200;
            dataGridView1.Columns[3].FillWeight = 60;
        }

 

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "ledger_name Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                DataGridViewRow dgr = dataGridView1.CurrentRow;
                xLedgerNo = dgr.Cells[0].Value.ToString();
                xLedgerName = dgr.Cells[1].Value.ToString();
                if (xLedgerName == "")
                {
                    MessageBox.Show("Please select different Customer");
                    return;
                }
                xLedgerMobileNo = dgr.Cells[2].Value.ToString();
                xLedgerAddress = dgr.Cells[3].Value.ToString();
                xLedgerAddress = dgr.Cells[3].Value.ToString();
                this.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xLedgerNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            xLedgerName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (xLedgerName == "")
            {
                MessageBox.Show("Please select different Customer");
                return;
            }
            xLedgerMobileNo = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            xLedgerAddress = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
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
