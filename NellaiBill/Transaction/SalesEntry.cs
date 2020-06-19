using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NellaiBill.Common;
using NellaiBill.Models;

namespace NellaiBill.Master
{
    public partial class SalesEntry : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public SalesEntry()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["Qty"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridView1.Columns["product_name"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridView1.Columns["product_name"].DefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dataGridView1.Columns["Qty"].DefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dtpDate.Focus();
            cmbPaymentMode.SelectedIndex = 0;
            cmbBillType.SelectedIndex = 0;
            lblInvoiceNo.Text = xDb.GetMaxId("sales_id", "sales").ToString();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;

            DataGridViewRow row = this.dataGridView1.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Yellow;
            this.KeyPreview = true;
            btnSaveBill.Enabled = true;
        }

        private void AddDataToGrid()
        {
            if (txtTax.Text == "" || txtQty.Text == "" || txtDiscountValue.Text == "" || txtDiscountValue.Text == "")
            {
                MessageBox.Show("Please Enter required fields ");
                return;
            }
            try
            {
                if (int.Parse(txtStock.Text) >= int.Parse(txtQty.Text))
                {

                    string xStockId = txtStockId.Text;
                    string xItemNo = txtItemNo.Text;
                    double xAmount = double.Parse(txtUnitPrice.Text) * double.Parse(txtQty.Text);

                    double xAmountAfterDiscount = xAmount - double.Parse(txtDiscountValue.Text);
                    double xGstPercentage = double.Parse(txtTax.Text);
                    double xGstValue = (xAmountAfterDiscount) * xGstPercentage / 100;

                    double xTotalAmount = Math.Round(xAmountAfterDiscount + xGstValue);

                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {

                        int xDataGridStockId = Convert.ToInt32(dr.Cells["Id"].Value);
                        if (Convert.ToInt32(xStockId) == xDataGridStockId)
                        {
                            MessageBox.Show("Item entered already.");
                            DataClear();
                            return;
                        }
                    }
                    string xDiscountPercentage = txtDiscPercentage.Text == "0" ? "0.00" : Convert.ToDecimal(txtDiscPercentage.Text).ToString("#.##");
                    string xDiscountValue = txtDiscountValue.Text == "0" ? "0.00" : Convert.ToDecimal(txtDiscountValue.Text).ToString("#.##");
                    this.dataGridView1.Rows.Add(
                    xStockId,
                    xItemNo,
                    txtItem.Text,
                    txtBatch.Text,
                    Convert.ToDateTime(txtExpDate.Text).ToString("yyyy-MM-dd"),
                    txtStock.Text,
                    txtUnitPrice.Text,
                    txtMrp.Text,
                    txtQty.Text,
                    xAmount,
                    xDiscountPercentage,
                    xDiscountValue,
                    Convert.ToDecimal(xAmountAfterDiscount),
                    Convert.ToDecimal(xGstPercentage),
                    Convert.ToDecimal(xGstValue),
                    Convert.ToDecimal(xTotalAmount),
                    "DEL");

                    CalculateTotalAmount();
                    DataClear();

                    dataGridView1.Columns["product_name"].Width = 200;
                    dataGridView1.Columns["ExpDate"].Width = 100;
                    dataGridView1.Columns["DGDelete"].Width = 40;
                    dataGridView1.Columns["Qty"].ReadOnly = false;
                    dataGridView1.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["GstPercentage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["GstValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["DiscValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["DiscPercentage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["AmountAfterDiscount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                }
                else
                {
                    MessageBox.Show("Please Enter Lesser than Stock");
                    txtQty.Focus();
                }

            }
            catch (Exception e)
            {
                string x = e.ToString();
            }
        }

        private void CalculateTotalAmount()
        {
            double xAmount = 0;
            double xTotalAmount = 0;
            double xGstValue = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                xAmount += Convert.ToDouble(dr.Cells["TotalAmount"].Value);
                xGstValue += Convert.ToDouble(dr.Cells["GstValue"].Value);
            }

            xTotalAmount = xAmount;
            lbl_total_amount_value.Text = xTotalAmount.ToString();

        }
        private void DataClear()
        {
            txtItem.Text = "";
            txtBatch.Text = "";
            txtExpDate.Text = "";
            txtUnitPrice.Text = "";
            txtMrp.Text = "";
            txtQty.Text = "";
            txtStock.Text = "";
            txtTax.Text = "";
            txtItemNo.Text = "";
            txtStockId.Text = "";
            txtDiscPercentage.Text = "";
            txtDiscountValue.Text = "";
        }

        private void DataClearAfterSave()
        {
            txtCustomerMobileNo.Text = "";
            rchCustomerAddress.Text = "";
            txtPaid.Text = "0";
            txtBalance.Text = "";
            dataGridView1.Rows.Clear();
            cmbPaymentMode.Text = "Please Select";
            lbl_total_amount_value.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDataToGrid();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Qty")
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.CurrentCell.ColumnIndex;


                double xQty = double.Parse(dataGridView1.Rows[rowindex].Cells["Qty"].Value.ToString());
                double xCurrentStock = double.Parse(dataGridView1.Rows[rowindex].Cells["Stock"].Value.ToString());
                double xPrice = double.Parse(dataGridView1.Rows[rowindex].Cells["UnitPrice"].Value.ToString());
                double xDiscountPercentage = double.Parse(dataGridView1.Rows[rowindex].Cells["DiscPercentage"].Value.ToString());
                double xGstPercentage = double.Parse(dataGridView1.Rows[rowindex].Cells["GstPercentage"].Value.ToString());
                double xAmount = xQty * xPrice;
                double xDiscountValue = xAmount * (xDiscountPercentage / 100);
                double xAmountAfterDiscount = xAmount - xDiscountValue;
                double xGstValue = (xAmountAfterDiscount) * xGstPercentage / 100;
                double xTotalAmount = Math.Round(xAmountAfterDiscount + xGstValue);
                if (xQty == 0)
                {
                    MessageBox.Show(" Qty Must be greater than 0");
                    dataGridView1.Rows[rowindex].Cells["Qty"].Value = 1;
                    return;
                }
                if (xQty > xCurrentStock)
                {
                    MessageBox.Show("Changed Qty is " + xQty + " greater than " + xCurrentStock);
                    dataGridView1.Rows[rowindex].Cells["Qty"].Value = 1;
                    return;
                }
                else
                {
                    dataGridView1.Rows[rowindex].Cells["Amount"].Value = xAmount;
                    dataGridView1.Rows[rowindex].Cells["DiscValue"].Value = xDiscountValue;
                    dataGridView1.Rows[rowindex].Cells["AmountAfterDiscount"].Value = xAmountAfterDiscount;
                    dataGridView1.Rows[rowindex].Cells["GstValue"].Value = xGstValue;
                    dataGridView1.Rows[rowindex].Cells["TotalAmount"].Value = xTotalAmount;
                }
                CalculateTotalAmount();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DGDelete"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                CalculateTotalAmount();
            }
        }

        private void SaveData(string xBillStatus)
        {

            if (cmbPaymentMode.Text == "Please Select")
            {
                MessageBox.Show("Please Choose Payment");
                cmbPaymentMode.Select();
                return;
            }
            if (cmbBillType.Text == "Please Select")
            {
                MessageBox.Show("Please Choose Bill Type");
                cmbBillType.Select();
                return;
            }
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
            int xSalesId = xDb.GetMaxId("sales_id", "sales");
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            double xLessAmount = 0;
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
                        int xStockId = Convert.ToInt32(dr.Cells["Id"].Value);
                        int xProductId = Convert.ToInt32(dr.Cells["ItemNoDg1"].Value);
                        int xSalesQty = Convert.ToInt32(dr.Cells["Qty"].Value);
                        double UnitPrice = Convert.ToDouble(dr.Cells["UnitPrice"].Value);
                        double xAmount = xSalesQty * UnitPrice;
                        double xGstPercentage = Convert.ToDouble(dr.Cells["GstPercentage"].Value);
                        //double xUnitMrp = UnitPrice + (UnitPrice * xGstPercentage / 100);
                        double xMrp = Convert.ToDouble(dr.Cells["Mrp"].Value);
                        string xBatch = dr.Cells["Batch"].Value.ToString();
                        string xQrySalesDetails = "insert into   sales_details" +
                           "(sales_id,txno,product_id,batch_id,expiry_date,qty,unit_rate,amount,gst,discount_percentage,unit_mrp) " +
                           "values(" + xSalesId + "," +
                             " '" + xTxNo + "'," +
                           " '" + xProductId + "'," +
                            " '" + xBatch + "'," +
                            " '" + dr.Cells["ExpDate"].Value + "'," +
                           " " + xSalesQty + "," +
                           " " + Convert.ToDouble(dr.Cells["UnitPrice"].Value) + "," +
                           " " + xAmount + "," +
                           " " + Convert.ToDouble(dr.Cells["GstPercentage"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["DiscPercentage"].Value) + "," +
                           " " + xMrp + " )";
                        xLessAmount += Convert.ToDouble(dr.Cells["DiscValue"].Value);
                        myCommand.CommandText = xQrySalesDetails;
                        myCommand.ExecuteNonQuery();

                        StockResponseModel stockResponseModel = xDb.GetStockFromQuery("select * from stock where product_id = " + xProductId + " and batch_id = '" + xBatch + "' and mrp = '" + xMrp + "'");

                        int xOldQty = 0;
                        int xNewQty = 0;
                        xOldQty = stockResponseModel.Qty;
                        xNewQty =  xOldQty- xSalesQty;
                        string xUpdateStockQry = "update stock set " +
                            " qty =  " + xNewQty + ", updated_by = '" + xUser + "', updated_on = '" + xCurrentDateTime + "' " +
                            " where product_id=" + xProductId + " " +
                            " and batch_id = '" + xBatch + "' " +
                            " and mrp = '" + xMrp + "'";
                        

                  
                        myCommand.CommandText = xUpdateStockQry;
                        myCommand.ExecuteNonQuery();

                        string xReason = "NEW SALES";
                        string xQryStockHistory = "insert into stock_history" +
                         " (product_id,old_qty,change_qty,current_qty," +
                         " mrp,batch_id,expiry_date,reason,created_by,created_on)" +
                         " values(" + xProductId  + "," + xOldQty + "," + xSalesQty + "," + xNewQty + "," + xMrp + "," +
                         " '" + xBatch + "','" + txtExpDate.Text + "','" + xReason + "'," +
                         " '" + xUser  + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                         + "')";

                        myCommand.CommandText = xQryStockHistory;
                        myCommand.ExecuteNonQuery();

                    }

                    string xQrySalesMain = "insert into   sales" +
                          "(sales_id,date,patient_id,less_amount,service_amount,total_amount," +
                          "mode_of_payment,terms_of_delivery,created_by,created_on) " +
                          "values(" + xSalesId + "," +
                          " '" + dtpDate.Value.ToString("yyyy-MM-dd") + "'," +
                          " '" + Convert.ToInt32(txtCustomerNo.Text.ToString()) + "'," +
                          " '" + xLessAmount + "'," +
                          " '0'," +
                          " '" + Convert.ToDouble(lbl_total_amount_value.Text) + "'," +
                          " '" + cmbPaymentMode.Text.ToString() + "'," +
                          " '" + cmbBillType.Text.ToString() + "'," +
                          " '" + xUser + "','" + xCurrentDateTime + "' )";

                    myCommand.CommandText = xQrySalesMain;
                    myCommand.ExecuteNonQuery();

                    myTrans.Commit();
                    MessageBox.Show("Record Saved Succesfully Id is " + xSalesId);
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

            DataClear();
            DataClearAfterSave();

            lblInvoiceNo.Text = xDb.GetMaxId("sales_id", "sales").ToString();
        }

        private void txtDiscPercentage_Leave(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please Enter Qty ");
                txtQty.Focus();
                return;
            }
            if (txtMrp.Text == "")
            {
                MessageBox.Show("Please Choose Mrp ");
                txtMrp.Focus();
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

            // double xAmount = double.Parse(txtQty.Text) * double.Parse(txtMrp.Text);
            double xAmount = double.Parse(txtQty.Text) * double.Parse(txtUnitPrice.Text);
            txtDiscountValue.Text = (xAmount * (double.Parse(txtDiscPercentage.Text) / 100)).ToString();

        }

        private void txtDiscountValue_Leave(object sender, EventArgs e)
        {

            if (txtMrp.Text == "")
            {
                MessageBox.Show("Please Choose Mrp ");
                txtMrp.Focus();
                return;

            }

            if (txtQty.Text == "")
            {
                MessageBox.Show("Please Enter Qty ");
                txtQty.Focus();
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

            //double xAmount = double.Parse(txtQty.Text) * double.Parse(txtMrp.Text);
            double xAmount = double.Parse(txtQty.Text) * double.Parse(txtUnitPrice.Text);
            txtDiscPercentage.Text = ((double.Parse(txtDiscountValue.Text) / xAmount) * 100).ToString();
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtPaid.Text != "")
            {
                double xTotalAmount = Convert.ToDouble(lbl_total_amount_value.Text);
                double xPaidAmount = Convert.ToDouble(txtPaid.Text);
                double xBalanceAmount = xPaidAmount - xTotalAmount;
                txtBalance.Text = xBalanceAmount.ToString();
            }

        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
           //string  xUserName=(xDb.GetUserNameFromPassword(txtUserPassword.Text));
           // if (xUserName != "")
           // {
           //     btnSaveBill.Enabled = xDb.CheckUserExists(txtUserPassword.Text);
           //     btnSaveBill.BackColor = Color.Red;
               
           // }
           // else
           // {
           //     btnSaveBill.Enabled = xDb.CheckUserExists(txtUserPassword.Text);
           //     btnSaveBill.BackColor = Color.LavenderBlush;
           // }

        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            SaveData("S");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchItem search = new SearchItem("sales");
            search.ShowDialog();
            if (search.xItemNo.ToString() != "0")
            {
                txtItem.Text = search.xItemName.ToString();
                txtUnitPrice.Text = search.xUnitPrice.ToString();
                txtMrp.Text = search.xMrp.ToString();
                txtBatch.Text = search.xBatch.ToString();
                txtExpDate.Text = search.xExpDate.ToString();
                txtStock.Text = search.xStock.ToString();
                txtStockId.Text = search.xStockId.ToString();
                txtItemNo.Text = search.xItemNo.ToString();
                txtTax.Text = search.xTax.ToString();
                txtDiscountValue.Text = "0";
                txtDiscPercentage.Text = "0";
                txtQty.Select();
            }
        }

        private void txtLedgerSearch_Click(object sender, EventArgs e)
        {
            SearchPatient search = new SearchPatient();
            search.ShowDialog();
            if (search.xPatientId.ToString() != "0")
            {
                txtCustomerNo.Text = search.xPatientId.ToString();
                txtCustomerName.Text = search.xPatientName.ToString();
                txtCustomerMobileNo.Text = search.xPatientMobileNo.ToString();
                rchCustomerAddress.Text = search.xPatientAddress.ToString();
            }

        }

        private void SalesEntry_KeyDown(object sender, KeyEventArgs e)
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
                btnSaveBill.PerformClick();
            }
        }

        private void txtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyNumeric(e);      
        }

        private void AcceptOnlyNumeric(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyNumeric(e);
        }

        private void txtDiscPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyNumeric(e);
        }

        private void txtDiscountValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptOnlyNumeric(e);
        }
    }
}




