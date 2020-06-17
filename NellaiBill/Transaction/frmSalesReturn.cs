using MySql.Data.MySqlClient;
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
    public partial class frmSalesReturn : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();

        string xQry = "select s.sales_id, s.date,i.product_id,i.product_name,s.batchid,s.qty,s.unitmrp" +
            " from sales s1, " +
            " sales_details s, " +
            " m_product i " +
            " where s1.sales_id=s.sales_id " +
            " and i.product_id=s.product_id";

        public frmSalesReturn()
        {
            InitializeComponent();
        }

        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select account_ledger_id,ledger_name from account_ledger where ledger_undergroup_no=5", cmbCustomer, "account_ledger_id", "ledger_name");
            xDb.LoadComboBox("select product_id,product_name from m_product", cmbItem, "product_id", "product_name");
            dataGridView1.ReadOnly = true;
        }

        private void btnView_Date_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
             " and s.date>='" + dtpFromDate.Text + "' " +
             " and s.date <= '" + dtpToDate.Text + "'" +
             " ", dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtItemNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtBatch.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtOldQty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMrp.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            txtCreditNoteNo.Text = xDb.GetMaxId("accounts_credit_note_id", "accounts_credit_note").ToString();
        }

        private void btnView_Supplier_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
        " and s1.customerno=" + cmbCustomer.SelectedValue + " " +
        " ", dataGridView1);
        }

        private void btnView_Item_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
              " and s.product_id=" + cmbItem.SelectedValue + " " +
                " ", dataGridView1);
        }

        private void btnView_Invoice_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
             " and s.sales_id=" + Convert.ToInt32(txtsales_id.Text.ToString()) + " " +
     " ", dataGridView1);
        }

        private void mbtnSalesReturn_Click(object sender, EventArgs e)
        {
            if (txtCreditNoteNo.Text == "")
            {
                MessageBox.Show("Please Load Data");
                return;
            }
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Please Load Data");
                return;
            }
            if (txtBatch.Text == "")
            {
                MessageBox.Show("Please Load Data");
                return;
            }
            if (txtOldQty.Text == "")
            {
                MessageBox.Show("Please Load Data");
                return;
            }
            if (txtChangeQty.Text == "")
            {
                MessageBox.Show("Please Enter Change Qty ");
                txtChangeQty.Focus();
                return;
            }
            if (rchRemarks.Text == "")
            {
                MessageBox.Show("Please Enter  Remarks ");
                rchRemarks.Focus();
                return;
            }
            ValidateQty();
            DataProcess();
        }
        public void ValidateQty()
        {
            if (Convert.ToInt32(txtOldQty.Text) >= Convert.ToInt32(txtChangeQty.Text))
            {

            }
            else
            {
                MessageBox.Show("Please Enter less than Old Qty");
                txtChangeQty.Text = "";
                txtChangeQty.Focus();
                return;
            }
        }
        public void DataProcess()
        {


            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();

                string xQryPurchaseReturn = "insert into   accounts_credit_note" +
                               "(accounts_credit_note_id,ledger_no," +
                               " credit_note_date,product_id,qty," +
                               " details,batchid) " +
                               " values(" + txtCreditNoteNo.Text + "," +
                               " " + cmbCustomer.SelectedValue + "," +
                               " '" + DateTime.Now + "'," +
                               " '" + txtItemName.Text + "'," +
                               " '" + Convert.ToInt32(txtChangeQty.Text) + "'," +
                               " '" + rchRemarks.Text + "'," +
                               " '" + txtBatch.Text + "')";
                int xItemNo = Convert.ToInt32(txtItemNo.Text);
                int xNewQty = Convert.ToInt32(txtChangeQty.Text) - Convert.ToInt32(txtOldQty.Text);

                string xQryStockUpdateEntry = "update stock set stock= stock + " + Convert.ToInt32(txtChangeQty.Text) + " " +
                    " where product_id=" + xItemNo + " and batch='" + txtBatch.Text + "';";

                //int xStockHistoryId = xDb.GetMaxId("stock_history_id", "stock_history");

                //string xQryStockDetails = "insert into   stock_history" +
                //    " (stock_history_id,product_id,category,qty,remarks)" +
                //    "  values(" + xStockHistoryId + "," + xItemNo + ",'SALES RETURN'," + Convert.ToInt32(txtChangeQty.Text) + ",'Item Returned')";

                string xQryStockDetails = "insert into stock_history" +
                         " (stock_history_itemno,stock_history_qty," +
                         " stock_history_mrp,stock_history_batch," +
                         " stock_history_datetime,stock_history_mode)" +
                         " values(" + xItemNo
                         + "," + txtChangeQty.Text
                         + "," + txtMrp.Text
                         + ",'" + txtBatch.Text
                         + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                         + "','SALES RETURN')";


                myCommand.CommandText = xQryPurchaseReturn;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = xQryStockUpdateEntry;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = xQryStockDetails;
                myCommand.ExecuteNonQuery();

                myTrans.Commit();
                MessageBox.Show("Sales Item Returned.");
                DataClear();
            }

        }
        public void DataClear()
        {
            txtBatch.Text = "";
            txtChangeQty.Text = "";
            txtCreditNoteNo.Text = "";
            txtItemName.Text = "";
            txtOldQty.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
