using MySql.Data.MySqlClient;
using NellaiBill.Common;
using NellaiBill.Models;
using System;
using System.Windows.Forms;

namespace NellaiBill.Transaction
{
    public partial class PurchaseReturn : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        string xQry = "select  " +
                " pu.purchase_id, " +
                " p.product_id, " +
                " p.product_name, " +
                " pd.batch_id, " +
                " pd.expiry_date, " +
                " pd.qty, " +
                " pd.mrp " +
                " from purchase_details pd, " +
                " purchase pu," +
                " m_product p " +
                " where p.product_id = pd.product_id " +
                " and pu.purchase_id = pd.purchase_id";
        public PurchaseReturn()
        {
            InitializeComponent();
        }

        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select account_ledger_id,ledger_name from account_ledger where ledger_undergroup_no=4", cmbSupplier, "account_ledger_id", "ledger_name");
            xDb.LoadComboBox("select product_id,product_name from m_product", cmbItem, "product_id", "product_name");
            dataGridView1.ReadOnly = true;
        }

        private void btnView_Date_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
                " and pu.date>='" + dtpFromDate.Text + "' " +
                " and pu.date <= '" + dtpToDate.Text + "'" +
                " ", dataGridView1);
        }

        private void btnView_Supplier_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
                " and pu.supplier_id=" + cmbSupplier.SelectedValue + " " +
                " ", dataGridView1);
        }

        private void btnView_Item_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
                  " and pd.product_id=" + cmbItem.SelectedValue + " " +
                    " ", dataGridView1);
        }

        private void btnView_Invoice_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
                " and pu.purchase_id=" + Convert.ToInt32(txtPurchaseInvoiceNo.Text.ToString()) + " " +
        " ", dataGridView1);
        }

        private void mbtnPurchaseReturn_Click(object sender, EventArgs e)
        {
            if (txtDebitNoteNo.Text == "")
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtItemNo.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
                txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
                txtBatch.Text = dataGridView1.Rows[e.RowIndex].Cells["batch_id"].Value.ToString();
                txtOldQty.Text = dataGridView1.Rows[e.RowIndex].Cells["qty"].Value.ToString();
                txtMrp.Text = dataGridView1.Rows[e.RowIndex].Cells["mrp"].Value.ToString();
                txtExpDate.Text = dataGridView1.Rows[e.RowIndex].Cells["expiry_date"].Value.ToString();
                txtPurchaseId.Text = dataGridView1.Rows[e.RowIndex].Cells["purchase_id"].Value.ToString();

            }
            txtDebitNoteNo.Text = xDb.GetMaxId("purchase_return_id", "purchase_return").ToString();

        }

        private void txtChangeQty_Leave(object sender, EventArgs e)
        {
            ValidateQty();
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
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                int xProductId = Convert.ToInt32(txtItemNo.Text);
                string xBatch = txtBatch.Text;
                double xMrp = Convert.ToDouble(txtMrp.Text);
                string xReason = "PURCHASE RETURN ";
                string xExpiryDate = txtExpDate.Text;
                string xQryPurchaseReturn = "insert into   purchase_return" +
                               "(purchase_id," +
                               " date,product_id,qty,mrp,batch_id,expiry_date,reason,created_by,created_on) " +
                               " values("+ Convert.ToInt32(txtPurchaseId.Text) + "," +
                               " '" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                               " '" + xProductId + "'," +
                               " '" + Convert.ToInt32(txtChangeQty.Text) + "'," +
                               " '" + xMrp + "'," +
                               " '" + xBatch + "'," +
                               " '" + xExpiryDate + "'," +
                               " '" + xReason + rchRemarks.Text + "'," +
                               " '" + xUser + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                         + "')";

                StockResponseModel stockResponseModel = xDb.GetStockFromQuery("select * from stock where product_id = " + xProductId + " and batch_id = '" + xBatch + "' and mrp = '" + xMrp + "'");

                int xStockOldQty = 0;
                int xStockNewQty = 0;
                xStockOldQty = stockResponseModel.Qty;
                int xChangeQty = Convert.ToInt32(txtChangeQty.Text);
                if (xChangeQty > xStockOldQty)
                {
                    MessageBox.Show("Stock Not Exists /Purchase return done");
                    return;
                }
                xStockNewQty = xStockOldQty  - xChangeQty;

                string xQryStockUpdateEntry = "update stock set " +
                            " qty =  " + xStockNewQty + ", updated_by = '" + xUser + "', updated_on = '" + xCurrentDateTime + "' " +
                            " where product_id=" + xProductId + " " +
                            " and batch_id = '" + xBatch + "' " +
                            " and mrp = '" + xMrp + "'";
                string xQryStockHistory = "insert into stock_history" +
                        " (product_id,old_qty,change_qty,current_qty," +
                        " mrp,batch_id,expiry_date,reason,created_by,created_on)" +
                        " values(" + xProductId + "," + xStockOldQty + "," + xChangeQty + "," + xStockNewQty + "," + xMrp + "," +
                        " '" + xBatch + "','" + xExpiryDate + "','" + xReason + "'," +
                        " '" + xUser + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        + "')";
              

                myCommand.CommandText = xQryPurchaseReturn;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = xQryStockUpdateEntry;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = xQryStockHistory;
                myCommand.ExecuteNonQuery();

                myTrans.Commit();
                MessageBox.Show("Purchase Item Returned.");
                DataClear();
            }
            }
        public void DataClear()
        {
            txtBatch.Text = "";
            txtChangeQty.Text = "";
            txtDebitNoteNo.Text = "";
            txtItemName.Text = "";
            txtOldQty.Text = "";
            rchRemarks.Text = "";
            txtPurchaseId.Text = "";
            txtExpDate.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
