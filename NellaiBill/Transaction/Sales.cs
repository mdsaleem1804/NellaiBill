using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace NellaiBill.Master
{
    public partial class SalesEntry : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();

        string xLoggedinUserName = "";
        public SalesEntry()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadGridView2();
            dataGridView1.Columns["Qty"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridView1.Columns["ItemName"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridView1.Columns["ItemName"].DefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);           
            dataGridView1.Columns["Qty"].DefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dtpDate.Focus();
            cmbPaymentMode.SelectedIndex = 0;
            cmbBillType.SelectedIndex = 0;
            cmbCustomer.Select();
            btnAdd.Enabled = false;
            lblInvoiceNo.Text = xDb.GetMaxId("salesinvoiceno", "inv_salesentry1").ToString();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;

            DataGridViewRow row = this.dataGridView1.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Yellow;
        }
        private void LoadComboBox()
        {
            xDb.LoadComboBox("select account_ledger_id,ledger_name from account_ledger where ledger_undergroup_no=5", cmbCustomer, "account_ledger_id", "ledger_name");
        }


        private void AddDataToGrid()
        {
            if (txtTax.Text == "")
            {
                MessageBox.Show("Please Enter Tax");
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

                    dataGridView1.Columns["ItemName"].Width = 200;
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

                    txtSearch.Select();

                }
                else
                {
                    MessageBox.Show("Please Enter Lesser than Stock");
                    txtQty.Focus();
                }
                btnAdd.Enabled = false;
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
            btnAdd.Enabled = false;
        }


        private void DataClearAfterSave()
        {
            txtCustomerMobileNo.Text = "";
            rchCustomerAddress.Text = "";
            txtPaid.Text = "0";
            txtBalance.Text = "";
            dataGridView1.Rows.Clear();

            lbl_total_amount_value.Text = "";
        }
        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                xDb.connection = new MySqlConnection(xDb.conString);

                int xCustomerId = Int32.Parse(cmbCustomer.SelectedValue.ToString());
                string selectQuery = "select ledger_address,ledger_mobile_no from account_ledger  where account_ledger_id=" + xCustomerId;
                xDb.connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, xDb.connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rchCustomerAddress.Text = reader[0].ToString();
                    txtCustomerMobileNo.Text = reader[1].ToString();
                }
                xDb.connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            if (Int32.Parse(cmbCustomer.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Please Choose Ledger");
                cmbCustomer.Select();
                return;
            }

            if (!(dataGridView1.Rows.Count > 0))
            {
                MessageBox.Show("Please add data");
                return;
            }
            int xSalesId = xDb.GetMaxId("salesinvoiceno", "inv_salesentry1");
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
                        int xStockId = Convert.ToInt32(dr.Cells["Id"].Value);
                        int xItemNo = Convert.ToInt32(dr.Cells["ItemNoDg1"].Value);
                        double xQty = Convert.ToDouble(dr.Cells["Qty"].Value);
                        double UnitPrice = Convert.ToDouble(dr.Cells["UnitPrice"].Value);
                        double xAmount = xQty * UnitPrice;
                        double xGstPercentage = Convert.ToDouble(dr.Cells["GstPercentage"].Value);
                        //double xUnitMrp = UnitPrice + (UnitPrice * xGstPercentage / 100);
                        double xMrp = Convert.ToDouble(dr.Cells["Mrp"].Value);
                        string xBatch = dr.Cells["Batch"].Value.ToString();
                        string xQrySalesDetails = "insert into   inv_salesentry" +
                           "(salesinvoiceno,date,customerno,itemno,batchid," +
                           "dateexpired,qty,unitrate,amount," +
                           "vat,discountpercentage," +
                           "createdason,updatedason,unitmrp) " +
                           "values(" + xSalesId + "," +
                             " '" + Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") + "'," +
                            " '" + Convert.ToInt32(cmbCustomer.SelectedValue.ToString()) + "'," +
                           " '" + xItemNo + "'," +
                            " '" + xBatch + "'," +
                            " '" + dr.Cells["ExpDate"].Value + "'," +
                           " " + Convert.ToDouble(dr.Cells["Qty"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["UnitPrice"].Value) + "," +
                           " " + xAmount + "," +
                           " " + Convert.ToDouble(dr.Cells["GstPercentage"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["DiscPercentage"].Value) + "," +
                           " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                           " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                           " " + xMrp + " )";
                        xLessAmount += Convert.ToDouble(dr.Cells["DiscValue"].Value);

                        string xUpdateStockQry = "update inv_stockentry set " +
                            " stock = stock - " + xQty + " " +
                            " where itemno=" + xItemNo + " " +
                            " and batch = '" + xBatch + "' " +
                            " and mrp = '" + xMrp + "'";


                        myCommand.CommandText = xQrySalesDetails;
                        myCommand.ExecuteNonQuery();

                        myCommand.CommandText = xUpdateStockQry;
                        myCommand.ExecuteNonQuery();


                        string xQryStockDetails = "insert into audit_stock" +
                         " (audit_stock_itemno,audit_stock_qty," +
                         " audit_stock_mrp,audit_stock_batch," +
                         " audit_stock_datetime,audit_stock_mode)" +
                         " values(" + xItemNo
                         + "," + xQty
                         + "," + xMrp
                         + ",'" + xBatch
                         + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                         + "','NEW SALES')";

                        myCommand.CommandText = xQryStockDetails;
                        myCommand.ExecuteNonQuery();

                    }

                    string xQrySalesMain = "insert into   inv_salesentry1" +
                          "(salesinvoiceno,date,customerno,totalamount,lessamount," +
                          "modeofpayment,termsofdelivery,servicecharges,salesperson_id) " +
                          "values(" + xSalesId + "," +
                          " '" + dtpDate.Value.ToString("yyyy-MM-dd") + "'," +
                          " '" + Convert.ToInt32(cmbCustomer.SelectedValue.ToString()) + "'," +
                          " '" + Convert.ToDouble(lbl_total_amount_value.Text) + "'," +
                          " '" + xLessAmount + "'," +
                          " '" + cmbPaymentMode.Text.ToString() + "'," +
                          " '" + cmbBillType.Text.ToString() + "'," +
                          " '" + xLoggedinUserName + "'," +
                          " '0' )";

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

            lblInvoiceNo.Text = xDb.GetMaxId("salesinvoiceno", "inv_salesentry1").ToString();
        }


        private void cmbCustomer_Leave(object sender, EventArgs e)
        {
            txtSearch.Select();
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

            double xAmount = double.Parse(txtQty.Text) * double.Parse(txtMrp.Text);
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

            double xAmount = double.Parse(txtQty.Text) * double.Parse(txtMrp.Text);
            txtDiscPercentage.Text = ((double.Parse(txtDiscountValue.Text) / xAmount) * 100).ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "itemname Like '%" + txtSearch.Text + "%'";
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }
        private void LoadGridView2()
        {
      
            xDb.LoadGrid("select s.stockno,s.itemno,i.itemname,s.stock,s.mrp,s.batch,s.expdate,i.gst from inv_stockentry s,m_item i where s.stock>0 and  s.itemno = i.itemno", dataGridView2);
            //dataGridView2.RowHeadersVisible = true;
            dataGridView2.ReadOnly = true;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[6].Visible = false;//expdate
            dataGridView2.Columns[7].Visible = false;//gst
            dataGridView2.Columns[2].FillWeight = 200;
            dataGridView2.Columns[3].FillWeight = 60;
            dataGridView2.Columns[4].FillWeight = 60;
            dataGridView2.Columns[5].FillWeight = 60;

        }
      
        private void FetchDataFromGrid(DataGridViewCellEventArgs e )
        {
            if (e.RowIndex >= 0)
            {
                txtStockId.Text = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString();
                txtItemNo.Text = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString()).ToString();
                txtItem.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStock.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                /*Included Gst Logic */
                double xUnitMrp = double.Parse(dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString());
                double xGstBefore = double.Parse(dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString()) / 100 + 1;
                double xUnitRate = (((xUnitMrp / xGstBefore)));

                txtUnitPrice.Text = xUnitRate.ToString("#.##");
                txtMrp.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                //txtPrice.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                /*Included v Logic Ended */
                txtBatch.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtExpDate.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTax.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            txtQty.Select();
            txtDiscountValue.Text = "0";
            txtDiscPercentage.Text = "0";
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.Red;

        }
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtPaid.Text != "") {
                double xTotalAmount = Convert.ToDouble(lbl_total_amount_value.Text);
                double xPaidAmount = Convert.ToDouble(txtPaid.Text);
                double xBalanceAmount = xPaidAmount - xTotalAmount;
                txtBalance.Text = xBalanceAmount.ToString();
            }
            
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            if (xDb.CheckUserExists(txtUserPassword.Text))
            {
                btnSaveBill.Enabled = xDb.CheckUserExists(txtUserPassword.Text);
                btnSaveBill.BackColor = Color.Red;
            }
            else
            {
                btnSaveBill.Enabled = xDb.CheckUserExists(txtUserPassword.Text);
                btnSaveBill.BackColor = Color.LavenderBlush;
            }

        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            SaveData("S");
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FetchDataFromGrid(e);
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FetchDataFromGrid(e);
        }

       //TO DO 
        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                moveUp();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                moveDown();
            }
            e.Handled = true;
        }

        private void moveUp()
        {
            if (dataGridView2.RowCount > 0)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int rowCount = dataGridView2.Rows.Count;
                    int index = dataGridView2.SelectedCells[0].OwningRow.Index;

                    if (index == 0)
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = dataGridView2.Rows;

                    // remove the previous row and add it behind the selected row.
                    DataGridViewRow prevRow = rows[index - 1];
                    rows.Remove(prevRow);
                    prevRow.Frozen = false;
                    rows.Insert(index, prevRow);
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[index - 1].Selected = true;
                }
            }
        }

        private void moveDown()
        {
            if (dataGridView2.RowCount > 0)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int rowCount = dataGridView2.Rows.Count;
                    int index = dataGridView2.SelectedCells[0].OwningRow.Index;

                    if (index == (rowCount - 2)) // include the header row
                    {
                        return;
                    }
                    DataGridViewRowCollection rows = dataGridView2.Rows;

                    // remove the next row and add it in front of the selected row.
                    DataGridViewRow nextRow = rows[index + 1];
                    rows.Remove(nextRow);
                    nextRow.Frozen = false;
                    rows.Insert(index, nextRow);
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[index + 1].Selected = true;
                }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtQty.Text = txtQty.Text.Remove(txtQty.Text.Length - 1);
            }
        }

        private void txtDiscPercentage_TextChanged(object sender, EventArgs e)
        {
            //TO DO -DECIMAL
        //    if (System.Text.RegularExpressions.Regex.IsMatch(txtDiscPercentage.Text, "[^0-9]"))
        //    {
        //        MessageBox.Show("Please enter only numbers.");
        //        txtDiscPercentage.Text = txtDiscPercentage.Text.Remove(txtDiscPercentage.Text.Length - 1);
        //        return;
        //    }
        
        }

        private void txtDiscountValue_TextChanged(object sender, EventArgs e)
        {
            //TO DO -DECIMAL
            //if (System.Text.RegularExpressions.Regex.IsMatch(txtDiscountValue.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Please enter only numbers.");
            //    txtDiscountValue.Text = txtDiscPercentage.Text.Remove(txtDiscountValue.Text.Length - 1);
            //    return;
            //}

        }
    }
}
    



