using MySql.Data.MySqlClient;
using NellaiBill.Common;
using NellaiBill.Master;
using NellaiBill.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NellaiBill.Transaction
{
    public partial class PurchaseEntry : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        GlobalClass globalClass = new GlobalClass();

        public PurchaseEntry()
        {
            InitializeComponent();
            txtDiscPercentage.Text = "0";
            txtDiscountValue.Text = "0";
            dtpExpDate.Value = DateTime.Now.AddMonths(3);
        }


        private void PurchaseEntry_Load(object sender, EventArgs e)
        {

            DataClear();
            lblInvoiceNo.Text = xDb.GetMaxId("purchase_id", "purchase").ToString();
            dtpExpDate.Value.Date.AddDays(365);
            this.KeyPreview = true;
            if (xDb.GetConfig().IsExpiry == "NO")
            {
                dtpExpDate.Enabled = false;
            }
            if (xDb.GetConfig().IsBatch == "NO")
            {
                txtBatch.Enabled = false;
                txtBatch.Text = "DEFAULT";
               // txtQty.Select();
            }
        }

        public void DataClear()
        {
            txtItemName.Text = "";
            txtItemNo.Text = "";
            txtBatch.Text = "";
            txtQty.Text = "";
            txtPackOf.Text = "1";
            txtTotalQty.Text = "";
            txtPR.Text = "";
            txtSR.Text = "";
            txtDiscPercentage.Text = "0";
            txtDiscountValue.Text = "0";
            // txtTax.Text = "Please select";
            txtLessAmount.Text = "0";


        }
        private void txtDiscPercentage_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtQty.Text == "")
                {
                    MessageBox.Show("Please Enter Qty ");
                    txtQty.Focus();
                    return;
                }
                if (txtPR.Text == "")
                {
                    MessageBox.Show("Please Enter Purchase Rate");
                    txtPR.Focus();
                    return;
                }
                if (txtDiscountValue.Text == "")
                {
                    txtDiscountValue.Text = "0";
                }
                if (txtDiscPercentage.Text == "")
                {
                    txtDiscPercentage.Text = "0";
                }
                if (txtTotalQty.Text == "")
                {
                    txtTotalQty.Text = "0";
                }
                double xAmount = double.Parse(txtTotalQty.Text) * double.Parse(txtPR.Text);
                txtDiscountValue.Text = (xAmount * (double.Parse(txtDiscPercentage.Text) / 100)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void txtDiscountValue_Leave(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please Enter Qty ");
                txtQty.Focus();
                return;
            }
            if (txtPR.Text == "")
            {
                MessageBox.Show("Please Enter Purchase Rate");
                txtPR.Focus();
                return;
            }
            if (txtDiscountValue.Text == "")
            {
                txtDiscountValue.Text = "0";
            }
            if (txtDiscPercentage.Text == "")
            {
                txtDiscPercentage.Text = "0";
            }
            if (txtTotalQty.Text == "")
            {
                txtTotalQty.Text = "0";
            }
            double xAmount = double.Parse(txtTotalQty.Text) * double.Parse(txtPR.Text);
            txtDiscPercentage.Text = ((double.Parse(txtDiscountValue.Text) / xAmount) * 100).ToString();

        }
        private void CheckEmptyTextbox_Message(TextBox textBox, string message)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Please Enter" + message);
                textBox.Focus();
                return;
            }

        }

        private void mbtnSaveBill_Click(object sender, EventArgs e)
        {
            if (txtCustomerNo.Text == "")
            {
                MessageBox.Show("Please Choose Ledger");
                return;
            }

            if (!(dataGridView1.Rows.Count > 0))
            {
                MessageBox.Show("Please add data");
                return;
            }
            int xPurchaseId = xDb.GetMaxId("purchase_id", "purchase");
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        int xTxNo = dr.Index + 1;
                        int xProductId = Convert.ToInt32(dr.Cells["product_id"].Value);
                        int xQty = Convert.ToInt32(dr.Cells["Qty"].Value);
                        int xPackOf = Convert.ToInt32(dr.Cells["PackOf"].Value);
                        int xTotalQty = xQty * xPackOf;
                        string xBatch = dr.Cells["Batch"].Value.ToString();
                        string xExpDate = dr.Cells["ExpDate"].Value.ToString();
                        double xMrp = Convert.ToDouble(dr.Cells["SellingPrice"].Value);
                        double xGst = Convert.ToDouble(dr.Cells["GstPercentage"].Value);
                        string xQryInsertPurchase = "insert into   purchase_details" +
                           "(purchase_id,txno,product_id,qty,batch_id,expiry_date,mrp,purchase_rate,discount,gst,total) " +
                           "values(" + xPurchaseId + "," +
                            " '" + xTxNo + "'," +
                           " '" + xProductId + "'," +
                           " '" + xTotalQty + "'," +
                           " '" + xBatch + "'," +
                           " '" + xExpDate + "'," +
                           " " + xMrp + "," +
                           " " + Convert.ToDouble(dr.Cells["Price"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["DiscPercentage"].Value) + "," +
                           " " + xGst + "," +
                           " " + Convert.ToDouble(dr.Cells["TotalAmount"].Value) + " )";

                        myCommand.CommandText = xQryInsertPurchase;
                        myCommand.ExecuteNonQuery();
                        string xLogMessage = "";
                        StockResponseModel stockResponseModel = xDb.GetStockFromQuery("select * from stock where product_id = " + xProductId + " and batch_id = '" + xBatch + "' and mrp = '" + xMrp + "'");
                        int xOldQty = 0;
                        int xNewQty = 0;
                        if (stockResponseModel.Mrp > 0)
                        {
                            xOldQty = stockResponseModel.Qty;
                            xNewQty = xTotalQty + xOldQty;
                            String xQryUpdateStock = "update stock set  " +
                                " qty=" + xNewQty + ",updated_by = '" + xUser + "', updated_on = '" + xCurrentDateTime + "' " +
                                " where product_id=" + xProductId + " and batch_id = '" + xBatch + "' " +
                                " and mrp = '" + xMrp + "'";
                            myCommand.CommandText = xQryUpdateStock;
                            myCommand.ExecuteNonQuery();
                            xLogMessage = "PURCHASE  UPDATED FOR OLD BATCH MRP";
                        }
                        else
                        {

                            string xQryStockEntry = "insert into   stock" +
                                "(product_id,qty,mrp,batch_id,expiry_date,created_by,created_on) " +
                                " values(" + xProductId + "," + xTotalQty + "," + xMrp + ",'" + xBatch + "'," +
                                " '" + xExpDate + "','" + xUser + "','" + xCurrentDateTime + "')";
                            myCommand.CommandText = xQryStockEntry;
                            myCommand.ExecuteNonQuery();
                            xLogMessage = "PURCHASE CREATED FOR NEW BATCH MRP";
                        }

                        xOldQty = stockResponseModel.Qty;
                        xNewQty = xTotalQty + xOldQty;
                        string xQryStockDetails = "insert into stock_history" +
                                  " (product_id,old_qty,change_qty,current_qty,mrp,batch_id,expiry_date,reason,created_by,created_on)" +
                                  "values(" + xProductId + "," + xOldQty + "," + xTotalQty + "," + xNewQty + "," + xMrp + ",'" + xBatch + "'," +
                                " '" + xExpDate + "','" + xLogMessage + "','" + xUser + "','" + xCurrentDateTime + "')";

                        myCommand.CommandText = xQryStockDetails;
                        myCommand.ExecuteNonQuery();
                    }

                    string xQryPurchaseMain = "insert into   purchase" +
                           "(purchase_id,date,supplier_id,bill_invoice_no,freight,others,less_amount,total_amount) " +
                           "values(" + xPurchaseId + "," +
                             " '" + Convert.ToDateTime(dtpPEDate.Text).ToString("yyyy-MM-dd") + "'," +
                             " '" + Convert.ToInt32(txtCustomerNo.Text.ToString()) + "'," +
                             " '" + txtCompanyInvoiceNo.Text.ToString() + "'," +
                             " '0'," +
                             " '0'," +
                            " '" + txtLessAmount.Text.ToString() + "'," +
                             " '" + Convert.ToDouble(lbl_total_amount_value.Text) + "')";

                    myCommand.CommandText = xQryPurchaseMain;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    dataGridView1.Rows.Clear();
                    DataClear();
                    MessageBox.Show("Record Saved Succesfully Id is " + xPurchaseId);
                    lblInvoiceNo.Text = xDb.GetMaxId("purchase_id", "purchase").ToString();
                    txtCompanyInvoiceNo.Text = "";
                    lblGoodsValue.Text = "0";
                    lblTotalDiscount.Text = "0";
                    lblTotalgst.Text = "0";
                    lblRoundOff.Text = "0";
                    lbl_total_amount_value.Text = "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record not saved - Error Occured" + ex.ToString());
                    myTrans.Rollback();
                }
                finally
                {
                    myCommand.Dispose();
                    myTrans.Dispose();
                    xDb.connection.Close();
                }

            }
        }

        private void txtLessAmount_Leave(object sender, EventArgs e)
        {
            CalculateTotalAmount();
            if (txtLessAmount.Text == "")
            {
                txtLessAmount.Text = "0";
            }
            lbl_total_amount_value.Text = (double.Parse(lbl_total_amount_value.Text) - double.Parse(txtLessAmount.Text)).ToString();
        }


        private void txtPackOf_Leave(object sender, EventArgs e)
        {

            CalculateTotalQty();

        }
        private void CalculateTotalQty()
        {
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please Enter Qty ");
                txtQty.Focus();
                return;
            }
            txtTotalQty.Text = ((double.Parse(txtQty.Text)) * double.Parse(txtPackOf.Text)).ToString("#.##");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DGDelete"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                CalculateTotalAmount();
            }
        }
        private void CalculateTotalAmount()
        {

            double xGoodsValue = 0;
            double xTotalDiscount = 0;
            double xTotalGst = 0;
            double xTotalAmount = 0;
            double xRoundOff = 0;
            double xTotalAmountAfterRoundOff = 0;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                xGoodsValue += Convert.ToDouble(dr.Cells["Amount"].Value);
                xTotalDiscount += Convert.ToDouble(dr.Cells["DiscValue"].Value);
                xTotalGst += Convert.ToDouble(dr.Cells["GstValue"].Value);
                xTotalAmount += Convert.ToDouble(dr.Cells["TotalAmount"].Value);
            }
            // xRoundOff= Math.Round(xTotalAmount)- xTotalAmount;
            xRoundOff = 0;
            xTotalAmountAfterRoundOff = xTotalAmount + xRoundOff;
            lblGoodsValue.Text = globalClass.DoFormat(xGoodsValue);
            lblTotalDiscount.Text = globalClass.DoFormat(xTotalDiscount);
            lblTotalgst.Text = globalClass.DoFormat(xTotalGst);
            lblRoundOff.Text = globalClass.DoFormat(xRoundOff);
            // lbl_total_amount_value.Text = globalClass.DoFormat(Math.Round(xTotalAmount));
            lbl_total_amount_value.Text = globalClass.DoFormat(xTotalAmount);
        }



        private void txtSR_Leave(object sender, EventArgs e)
        {

            if (txtPR.Text == "")
            {
                MessageBox.Show("Please Enter Purchase Rate");
                txtPR.Focus();
                return;
            }

            if (txtSR.Text == "")
            {
                MessageBox.Show("Please Enter Sales Rate");
                txtSR.Focus();
                return;
            }
            if (Convert.ToDouble(txtPR.Text) > Convert.ToDouble(txtSR.Text))
            {
                MessageBox.Show("Please Enter Sales Rate Greater than Purchase Rate");
                txtSR.Focus();
                return;
            }
            if (txtBatch.Text == "")
            {
                MessageBox.Show("Please Enter Batch");
                txtBatch.Focus();
                return;
            }
            if (txtItemNo.Text == "")
            {
                MessageBox.Show("Please Choose Item");
                txtBatch.Focus();
                return;
            }
            int xItemId = Convert.ToInt32(txtItemNo.Text.ToString());
            double xMrp = Convert.ToDouble(txtSR.Text.ToString());
            int xCount = xDb.GetTotalCount("select * from stock where product_id = " + xItemId + " and batch_id = '" + txtBatch.Text + "' and mrp =" + xMrp);
            if (xCount >= 1)
            {
                string selectQuery = "select qty from stock where product_id = " + xItemId + " and batch_id = '" + txtBatch.Text + "' and mrp =" + xMrp;
                xDb.connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, xDb.connection);
                MySqlDataReader reader = command.ExecuteReader();
                int xTotalBatchStock = 0;
                while (reader.Read())
                {
                    xTotalBatchStock += Convert.ToInt32(reader[0].ToString());
                    lblProductDetails.Text = "Entered Batch and MRP already exists with Stock - : " + xTotalBatchStock;
                }

            }
            else
            {
                lblProductDetails.Text = "New Batch and MRP";
            }
        }



        private void btnLedgerSearch_Click(object sender, EventArgs e)
        {
            SearchSupplier search = new SearchSupplier(4);
            search.ShowDialog();
            if (search.xSupplierNo.ToString() != "0")
            {
                txtCustomerNo.Text = search.xSupplierNo.ToString();
                txtCustomerName.Text = search.xSupplierName.ToString();
                txtCustomerMobileNo.Text = search.xSupplierMobileNo.ToString();
                rchCustomerAddress.Text = search.xSupplierAddress.ToString();
            }
        }

        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            SearchItem search = new SearchItem("purchase");
            search.ShowDialog();
            if (search.xItemNo.ToString() != "0")
            {
                txtItemName.Text = search.xItemName.ToString();
                txtItemNo.Text = search.xItemNo.ToString();
                cmbTax.Text = search.xTax.ToString();
                txtBatch.Select();
                if(xDb.GetConfig().IsBatch=="NO")
                {
                    txtBatch.Text = "DEFAULT";
                    txtQty.Select();
                }
            }
        }

        private void PurchaseEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.L)
            {
                btnLedgerSearch.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.I)
            {
                btnItemSearch.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                btnAdd.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                mbtnSaveBill.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtItemName.Text == "")
            {
                MessageBox.Show("Please Fill Item");
                return;
            }
            if (txtBatch.Text == "")
            {
                MessageBox.Show("Please Enter Batch ");
                txtBatch.Focus();
                return;
            }
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please Enter Qty ");
                txtQty.Focus();
                return;
            }
            if (txtPR.Text == "")
            {
                MessageBox.Show("Please Enter Purchase Rate");
                txtPR.Focus();
                return;
            }
            if (txtSR.Text == "")
            {
                MessageBox.Show("Please Enter Sales Rate");
                txtSR.Focus();
                return;
            }
            if (cmbTax.Text == "")
            {
                MessageBox.Show("Please Enter Tax");
                return;
            }


            double xAmount = (double.Parse(txtTotalQty.Text)) * double.Parse(txtPR.Text);
            double xAmountAfterDiscount = xAmount - double.Parse(txtDiscountValue.Text);
            double xGstValue = xAmountAfterDiscount * (double.Parse(cmbTax.Text) / 100);
            double xTotalAmount = xAmountAfterDiscount + xGstValue;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                string xItemNameGrid = dr.Cells["product_name"].Value.ToString();
                string xBatchGrid = dr.Cells["Batch"].Value.ToString();

                if ((txtItemName.Text == xItemNameGrid) && (txtBatch.Text == xBatchGrid))
                {
                    MessageBox.Show("Item entered already with same batch.");
                    return;
                }
            }
            int xItemNo = Int32.Parse(txtItemNo.Text.ToString());

            this.dataGridView1.Rows.Add(
                xItemNo,
                txtItemName.Text,
                txtBatch.Text,
                Convert.ToDateTime(dtpExpDate.Text).ToString("yyyy-MM-dd"),
                txtQty.Text,
                txtPackOf.Text,
                txtTotalQty.Text,
                txtPR.Text,
                txtSR.Text,
                xAmount,
                 globalClass.DoFormat(Convert.ToDouble(txtDiscPercentage.Text)),
                 globalClass.DoFormat(Convert.ToDouble(txtDiscountValue.Text)),
                 globalClass.DoFormat(Convert.ToDouble(xAmountAfterDiscount)),
                 globalClass.DoFormat(Convert.ToDouble(cmbTax.Text)),
                 globalClass.DoFormat(Convert.ToDouble(xGstValue)),
                 globalClass.DoFormat(Convert.ToDouble(xTotalAmount)),
                  "DEL");
            DataClear();
            CalculateTotalAmount();

        }



        private static void AcceptDecimal(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private static void AcceptNumeric(KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptNumeric(e);
        }

        private void txtPackOf_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptNumeric(e);
        }

        private void txtPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptDecimal(sender, e);
        }

        private void txtSR_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptDecimal(sender, e);
        }

        private void txtDiscPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptDecimal(sender, e);
        }

        private void txtDiscountValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptDecimal(sender, e);
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            CalculateTotalQty();
        }
    }
}
