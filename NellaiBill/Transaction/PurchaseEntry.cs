using MySql.Data.MySqlClient;
using NellaiBill.Master;
using System;
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
            lblInvoiceNo.Text = xDb.GetMaxId("purchaseinvoiceno", "inv_purchaseentry1").ToString();
            dtpExpDate.Value.Date.AddDays(365);
            this.KeyPreview = true;
        }

        public void DataClear()
        {
            txtItemName.Text="";
            txtItemNo.Text = "";
            txtBatch.Text = "";
            txtQty.Text = "";
            txtFreeQty.Text = "0";
            txtPackOf.Text = "1";
            txtTotalQty.Text = "";
            txtPR.Text = "";
            txtSR.Text = "";
            txtDiscPercentage.Text = "0";
            txtDiscountValue.Text = "0";
            txtTax.Text = "Please select";
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
            if (Int32.Parse(txtCustomerNo.Text.ToString()) == 0)
            {
                MessageBox.Show("Please Choose Suppliers");
                return;
            }

            if (!(dataGridView1.Rows.Count > 0))
            {
                MessageBox.Show("Please add data");
                return;
            }
            int xPurchaseId = xDb.GetMaxId("purchaseinvoiceno", "inv_purchaseentry1");
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        int xItemNo = Convert.ToInt32(dr.Cells["ItemNo"].Value);
                        double xQty = Convert.ToDouble(dr.Cells["Qty"].Value);
                        double xFreeQty = Convert.ToDouble(dr.Cells["FreeQty"].Value);
                        double xPackOf = Convert.ToDouble(dr.Cells["PackOf"].Value);
                        double xTotalQty = (xQty + xFreeQty) * xPackOf;
                        double xSellingPrice = Convert.ToDouble(dr.Cells["SellingPrice"].Value);
                        string xBatch = dr.Cells["Batch"].Value.ToString();
                        string xExpDate = dr.Cells["ExpDate"].Value.ToString();
                        double xProfit = 0.00;
                        string xQryInsertPurchase = "insert into   inv_purchaseentry" +
                           "(purchaseinvoiceno,itemno,dateexpired,batchid,qty," +
                           "freeqty,packno,originalprice,sellingprice,discount,vat," +
                           "total,nettotal,profit,date,createdason,updatedason) " +
                           "values(" + xPurchaseId + "," +
                           " '" + xItemNo + "'," +
                           " '" + xExpDate + "'," +
                            " '" + xBatch + "'," +
                           " " + xQty + "," +
                           " " + xFreeQty + "," +
                           " " + xPackOf + "," +
                           " " + Convert.ToDouble(dr.Cells["Price"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["SellingPrice"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["DiscPercentage"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["GstPercentage"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["Amount"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["TotalAmount"].Value) + "," +
                           " " + xProfit + "," +
                           " '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd") + "'," +
                           " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                           " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' )";

                        myCommand.CommandText = xQryInsertPurchase;
                        myCommand.ExecuteNonQuery();
                        string xLogMessage = "";
                        int xCount = xDb.GetTotalCount("select * from inv_stockentry where itemno = " + xItemNo + " and batch = '" + xBatch + "' and mrp = '" + xSellingPrice + "'");
                        if (xCount >= 1)
                        {
                            String xQryUpdateStock = "update inv_stockentry set stock=stock+" + xTotalQty + " where itemno=" + xItemNo + " and batch = '" + xBatch + "' and mrp = '" + xSellingPrice + "'";
                            myCommand.CommandText = xQryUpdateStock;
                            myCommand.ExecuteNonQuery();
                            xLogMessage = "PURCHASE  UPDATED FOR OLD BATCH MRP";
                        }
                        else
                        {

                            string xQryStockEntry = "insert into   inv_stockentry" +
                                "(itemno,stock,mrp,batch,expdate) " +
                                " values(" + xItemNo + "," + xTotalQty + "," + xSellingPrice + ",'" + xBatch + "','" + xExpDate + "')";
                            myCommand.CommandText = xQryStockEntry;
                            myCommand.ExecuteNonQuery();
                            xLogMessage = "PURCHASE CREATED FOR NEW BATCH MRP";
                        }


                        string xQryStockDetails = "insert into audit_stock" +
                                  " (audit_stock_itemno,audit_stock_qty," +
                                  " audit_stock_mrp,audit_stock_batch," +
                                  " audit_stock_datetime,audit_stock_mode)" +
                                  " values(" + xItemNo
                                  + "," + xTotalQty
                                  + "," + xSellingPrice
                                  + ",'" + xBatch
                                  + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                  + "','" + xLogMessage + "')";

                        myCommand.CommandText = xQryStockDetails;
                        myCommand.ExecuteNonQuery();
                    }

                    string xQryPurchaseMain = "insert into   inv_purchaseentry1" +
                           "(purchaseinvoiceno,supplierno,companyinvoiceno," +
                           "totalamount,date,freight,others) " +
                           "values(" + xPurchaseId + "," +
                           " '" + Convert.ToInt32(txtCustomerNo.Text.ToString()) + "'," +
                            " '" + txtCompanyInvoiceNo.Text.ToString() + "'," +
                            " '" + Convert.ToDouble(lbl_total_amount_value.Text) + "'," +
                               " '" + Convert.ToDateTime(dtpPEDate.Text).ToString("yyyy-MM-dd") + "'," +
                            " '0'," +
                            " '0' )";

                    myCommand.CommandText = xQryPurchaseMain;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    dataGridView1.Rows.Clear();
                    DataClear();
                    MessageBox.Show("Record Saved Succesfully Id is " + xPurchaseId);
                    lblInvoiceNo.Text = xDb.GetMaxId("purchaseinvoiceno", "inv_purchaseentry1").ToString();
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
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please Enter Qty ");
                txtQty.Focus();
                return;
            }
            if (txtFreeQty.Text == "")
            {
                txtFreeQty.Text = "0";
            }
            txtTotalQty.Text = ((double.Parse(txtQty.Text) + double.Parse(txtFreeQty.Text)) * double.Parse(txtPackOf.Text)).ToString("#.##");

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

            int xItemId = Convert.ToInt32(txtItemNo.Text.ToString());
            double xMrp = Convert.ToDouble(txtSR.Text.ToString());
            int xCount = xDb.GetTotalCount("select * from inv_stockentry where itemno = " + xItemId + " and batch = '" + txtBatch.Text + "' and mrp =" + xMrp);
            if (xCount >= 1)
            {
                string selectQuery = "select stock from inv_stockentry where itemno = " + xItemId + " and batch = '" + txtBatch.Text + "' and mrp =" + xMrp;
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

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBatch.Text = "";
            txtQty.Text = "";
            txtFreeQty.Text = "0";
            txtPackOf.Text = "1";
            txtTotalQty.Text = "";
            txtPR.Text = "";
            txtSR.Text = "";
            txtDiscPercentage.Text = "0";
            txtDiscountValue.Text = "0";
            txtTax.Text = "Please select";
            txtLessAmount.Text = "0";
            xDb.connection = new MySqlConnection(xDb.conString);
           
            string xItemNo = txtItemNo.Text.ToString();
            if (xItemNo == "0")
            {
                return;
            }
            //string selectQuery = "select i.itemno,i.itemname,t.tax_name " +
            //   " from m_item i,m_tax t where i.gst = t.tax_no and i.itemno=" + xItemNo;
            string selectQuery = "select i.itemno,i.itemname,i.gst" +
               " from m_item i where  i.itemno=" + xItemNo;
            xDb.connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, xDb.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //cmbTax.SelectedIndex = cmbTax.FindStringExact(reader[2].ToString());
                txtTax.Text = reader[2].ToString();
            }
            xDb.connection.Close();

        }

        private void btnLedgerSearch_Click(object sender, EventArgs e)
        {
            SearchLedger search = new SearchLedger(4);
            search.ShowDialog();
            if (search.xLedgerNo.ToString() != "0")
            {
                txtCustomerNo.Text = search.xLedgerNo.ToString();
                txtCustomerName.Text = search.xLedgerName.ToString();
                txtCustomerMobileNo.Text = search.xLedgerMobileNo.ToString();
                rchCustomerAddress.Text = search.xLedgerAddress.ToString();
            }
        }

        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            SearchItem search = new SearchItem();
            search.ShowDialog();
            if (search.xItemNo.ToString() != "0")
            {
                txtItemName.Text = search.xItemName.ToString();               
                txtItemNo.Text = search.xItemNo.ToString();
                txtTax.Text = search.xTax.ToString();
                txtBatch.Select();
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
            if (txtTax.Text == "")
            {
                MessageBox.Show("Please Enter Tax");
                return;
            }


            double xAmount = double.Parse(txtTotalQty.Text) * double.Parse(txtPR.Text);
            double xAmountAfterDiscount = xAmount - double.Parse(txtDiscountValue.Text);
            double xGstValue = xAmountAfterDiscount * (double.Parse(txtTax.Text) / 100);
            double xTotalAmount = xAmountAfterDiscount + xGstValue;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                string xItemNameGrid = dr.Cells["ItemName"].Value.ToString();
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
                txtFreeQty.Text,
                txtPackOf.Text,
                txtTotalQty.Text,
                txtPR.Text,
                txtSR.Text,
                xAmount,
                 globalClass.DoFormat(Convert.ToDouble(txtDiscPercentage.Text)),
                 globalClass.DoFormat(Convert.ToDouble(txtDiscountValue.Text)),
                 globalClass.DoFormat(Convert.ToDouble(xAmountAfterDiscount)),
                 globalClass.DoFormat(Convert.ToDouble(txtTax.Text)),
                 globalClass.DoFormat(Convert.ToDouble(xGstValue)),
                 globalClass.DoFormat(Convert.ToDouble(xTotalAmount)),
                  "DEL");
            DataClear();
            CalculateTotalAmount();

        }
    }
}
