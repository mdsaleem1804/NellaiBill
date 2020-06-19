using MySql.Data.MySqlClient;
using NellaiBill.Common;
using NellaiBill.Models;
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
    public partial class SalesReturn : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();

        string xQry = "select s.sales_id, s.date,i.product_id,i.product_name,sd.batch_id,sd.qty,sd.expiry_date,sd.unit_mrp" +
            " from sales s, " +
            " sales_details sd, " +
            " m_product i " +
            " where sd.sales_id=s.sales_id " +
            " and i.product_id=sd.product_id";

        public SalesReturn()
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
                txtItemNo.Text = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
                txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
                txtBatch.Text = dataGridView1.Rows[e.RowIndex].Cells["batch_id"].Value.ToString();
                txtOldQty.Text = dataGridView1.Rows[e.RowIndex].Cells["qty"].Value.ToString();
                txtMrp.Text = dataGridView1.Rows[e.RowIndex].Cells["unit_mrp"].Value.ToString();
                txtExpDate.Text = dataGridView1.Rows[e.RowIndex].Cells["expiry_date"].Value.ToString();
                txtSalesId.Text = dataGridView1.Rows[e.RowIndex].Cells["sales_id"].Value.ToString();
            }
            txtCreditNoteNo.Text = xDb.GetMaxId("sales_return_id", "sales_return").ToString();
        }

        private void btnView_Supplier_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
        " and s.customer_id=" + cmbCustomer.SelectedValue + " " +
        " ", dataGridView1);
        }

        private void btnView_Item_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
              " and sd.product_id=" + cmbItem.SelectedValue + " " +
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
                string xReason = "SALES RETURN ";
                string xExpiryDate = txtExpDate.Text;
                string xQrySalesReturn = "insert into   sales_return" +
                               "(sales_id," +
                               " date,product_id,qty,mrp,batch_id,expiry_date,reason,created_by,created_on) " +
                               " values(" + txtSalesId.Text + "," +
                               " '" + DateTime.Now + "'," +
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

                xStockNewQty = xStockOldQty + xChangeQty;

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


                myCommand.CommandText = xQrySalesReturn;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = xQryStockUpdateEntry;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = xQryStockHistory;
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
            txtSalesId.Text = "";
            txtExpDate.Text = "";
            dataGridView1.DataSource = null;
        }
    }
}
