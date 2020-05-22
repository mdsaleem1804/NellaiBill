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
    public partial class frmPurchaseReturn : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        string xQry = "select  " +
                " p.purchaseinvoiceno, " +
                " i.itemname, " +
                " p.batchid, " +
                " p.dateexpired, " +
                " p.qty, " +
                " p.freeqty, " +
                " p.packno " +
                " from inv_purchaseentry p, " +
                " inv_purchaseentry1 p1," +
                " m_item i " +
                " where i.itemno = p.itemno " +
                " and p.purchaseinvoiceno = p1.purchaseinvoiceno";
        public frmPurchaseReturn()
        {
            InitializeComponent();
        }

        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select account_ledger_id,ledger_name from account_ledger where ledger_undergroup_no=4", cmbSupplier, "account_ledger_id", "ledger_name");
            xDb.LoadComboBox("select itemno,itemname from m_item", cmbItem, "itemno", "itemname");
            dataGridView1.ReadOnly = true;
        }

        private void btnView_Date_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
                " and p.date>='" + dtpFromDate.Text + "' " +
                " and p.date <= '" + dtpToDate.Text + "'" +
                " ", dataGridView1);
        }

        private void btnView_Supplier_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
                " and p1.supplierno=" + cmbSupplier.SelectedValue + " " +
                " ", dataGridView1);
        }

        private void btnView_Item_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
                  " and p.itemno=" + cmbItem.SelectedValue + " " +
                    " ", dataGridView1);
        }

        private void btnView_Invoice_Click(object sender, EventArgs e)
        {
            xDb.LoadGrid(xQry +
                " and p.purchaseinvoiceno=" + Convert.ToInt32(txtPurchaseInvoiceNo.Text.ToString()) + " " +
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
                txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBatch.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtOldQty.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            txtDebitNoteNo.Text = xDb.GetMaxId("accounts_debit_note_id", "accounts_debit_note").ToString();

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
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();

                string xQryPurchaseReturn = "insert into   accounts_debit_note" +
                               "(accounts_debit_note_id,ledger_no," +
                               " debit_note_date,itemno,qty," +
                               " details,batchid) " +
                               " values(" + txtDebitNoteNo.Text + "," +
                               " " + cmbSupplier.SelectedValue + "," +
                               " '" + DateTime.Now + "'," +
                               " '" + txtItemName.Text + "'," +
                               " '" + Convert.ToInt32(txtChangeQty.Text) + "'," +
                               " '" + rchRemarks.Text + "'," +
                               " '" + txtBatch.Text + "')";
                int xItemNo = Convert.ToInt32(cmbItem.FindStringExact(txtItemName.Text.ToString()));
                int xNewQty = Convert.ToInt32(txtChangeQty.Text) - Convert.ToInt32(txtOldQty.Text);

                string xQryStockUpdateEntry = "update inv_stockentry set stock= stock - " + Convert.ToInt32(txtChangeQty.Text) + " " +
                    " where itemno="+xItemNo +" and batch='"+txtBatch.Text+"';";
                    
                int xStockHistoryId = xDb.GetMaxId("stock_history_id", "stock_history");
                //string xQryStockDetails = "insert into   stock_history" +
                //    " (stock_history_id,itemno,category,qty,remarks)" +
                //    "  values(" + xStockHistoryId + "," + xItemNo + ",'PURCHASE RETURN'," + Convert.ToInt32(txtChangeQty.Text) + ",'Item Returned')";
                string xQryStockDetails = "insert into audit_stock" +
                     " (audit_stock_itemno,audit_stock_qty," +
                     " audit_stock_mrp,audit_stock_batch," +
                     " audit_stock_datetime,audit_stock_mode)" +
                     " values(" + xItemNo
                     + "," + txtChangeQty.Text
                     + "," + 0
                     + ",'" + txtBatch.Text
                     + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                     + "','PURCHASE RETURN -ID " + xStockHistoryId + "')";

                myCommand.CommandText = xQryPurchaseReturn;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = xQryStockUpdateEntry;
                myCommand.ExecuteNonQuery();
                myCommand.CommandText = xQryStockDetails;
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
            dataGridView1.DataSource = null;
        }
    }
}
