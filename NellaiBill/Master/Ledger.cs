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
    public partial class Ledger : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        string xFormName = "";
        int xLedgerId;
        public Ledger(string formName)
        {
            InitializeComponent();
            xFormName = formName;
        }

        private void Ledger_Load(object sender, EventArgs e)
        {
            lblFormName.Text = xFormName;
            LoadGrid();
            DataClear();

        }
        private void LoadGrid()
        {

            int xLedgerGroupNo = (xFormName == "Supplier" ? 4 : 5);
            string xCustomerQuery = "select account_ledger_id," +
                "ledger_name as Name," +
                "ledger_address as Address," +
                "ledger_mobile_no as Mobile " +
                "from account_ledger where ledger_undergroup_no=" + xLedgerGroupNo;

            string xSupplierQuery = "select account_ledger_id," +
     "ledger_name as Name," +
     "ledger_address as Address," +
     "ledger_mobile_no as Mobile," +
      "ledger_unique_no as UniqueNo" +
     " from account_ledger where ledger_undergroup_no=" + xLedgerGroupNo;
            xDb.LoadGrid(xFormName == "Supplier" ? xSupplierQuery : xCustomerQuery, dataGridView1);

        }
        private void mBtnSave_Click(object sender, EventArgs e)
        {
            string xQry = "";
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Choose Name");
                return;
            }
            if (mBtnSaveUpdate.Text == "SAVE")
            {
                int xLedgerGroupNo = (xFormName == "Supplier" ? 4 : 5);
                int xAccountLedgerId = xDb.GetMaxId("account_ledger_id", "account_ledger");
                xQry = "insert into account_ledger (account_ledger_id,ledger_name,ledger_address,ledger_mobile_no,ledger_undergroup_no) " +
                    " values ( " + xAccountLedgerId + ",'" + txtName.Text + "', '" + rchAddress.Text + "','" + txtMobileNo.Text + "'," + xLedgerGroupNo + ")";
            }
            else
            {
                xQry = "update account_ledger set " +
                    " ledger_name = '" + txtName.Text + "', " +
                    " ledger_address = '" + rchAddress.Text + "', " +
                    " ledger_mobile_no = '" + txtMobileNo.Text + "' " +
                    " where  account_ledger_id= " + xLedgerId + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show(xFormName + "Saved/Updated");
            LoadGrid();
            DataClear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xLedgerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rchAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMobileNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mBtnSaveUpdate.Text = "UPDATE";
            mBtnDelete.Enabled = true;
        }

        private void mBtnDelete_Click(object sender, EventArgs e)
        {
            string xTableName = (xFormName == "Supplier" ? "purchase" : "sales");
            string xColumnName = (xFormName == "Supplier" ? "supplierno" : "customerno");
            if (xDb.CountRecord("select * from " + xTableName + " where " + xColumnName + " = " + xLedgerId + " ") >= 1)
            {
                MessageBox.Show("Selected " + xFormName + " is  mapped with other transaction");
                return;
            }
            else
            {
                string xQry = "delete from account_ledger  where  account_ledger_id= " + xLedgerId + "";
                xDb.DataProcess(xQry);
            }
            MessageBox.Show(xFormName + "Deleted");
            LoadGrid();
            DataClear();
        }

        private void DataClear()
        {
            txtName.Text = "";
            rchAddress.Text = "";
            txtMobileNo.Text = "";
            mBtnSaveUpdate.Text = "SAVE";
            mBtnDelete.Enabled = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
    }
}
