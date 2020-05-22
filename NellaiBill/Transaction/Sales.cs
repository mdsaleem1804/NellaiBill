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

        int xGBatch = 0;
        double xCGST = 0;
        double xSGST = 0;
        string xLoggedinUserName = "";
        public SalesEntry()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadGridView2();
            dtpDate.Focus();
            cmbPaymentMode.SelectedIndex = 0;
            cmbBillType.SelectedIndex = 0;
            cmbCustomer.Select();
            lblInvoiceNo.Text = xDb.GetMaxId("salesinvoiceno", "inv_salesentry1").ToString();
            //GetConfigValues();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.RowHeadersVisible = false;

            DataGridViewRow row = this.dataGridView1.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Yellow;
            
        }

        private void LoadGridView2()
        {           
            xDb.LoadGrid("select s.itemno,i.itemname,s.mrp,s.batch,s.stock from inv_stockentry s,m_item i where s.stock>0 and  s.itemno = i.itemno", dataGridView2);
            dataGridView2.ReadOnly = true;
            dataGridView2.Columns["itemno"].Visible = false;
            dataGridView2.Columns[1].FillWeight = 200;
            dataGridView2.Columns[2].FillWeight = 60;
            dataGridView2.Columns[3].FillWeight = 60;
            dataGridView2.Columns[4].FillWeight = 60;

        }
        private void LoadComboBox()
        {
            // xDb.LoadComboBox("select tax_no,tax_name from m_tax", cmbTax, "tax_name", "tax_name");
            //xDb.LoadComboBox("select gst as tax_name,gst as tax_name from m_item group by gst", cmbTax, "gst", "gst");

            // xDb.LoadComboBox("select unit_no,unit_name from m_unit", cmbUnit, "unit_no", "unit_name");
            xDb.LoadComboBox("select account_ledger_id,ledger_name from account_ledger where ledger_undergroup_no=5", cmbCustomer, "account_ledger_id", "ledger_name");
            xDb.LoadComboBox("select s.itemno,i.itemname from inv_stockentry s,m_item i where s.stock>0 and  s.itemno = i.itemno", cmbItem, "itemno", "itemname");
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
                if (int.Parse(txt_stock.Text) >= int.Parse(txt_qty.Text))
                {
                    string xStockId = cmbItem.SelectedValue.ToString();
                    double xAmount = double.Parse(txtPrice.Text) * double.Parse(txt_qty.Text);

                    double xAmountAfterDiscount = xAmount - double.Parse(txtDiscountValue.Text);
                    double xGstPercentage = double.Parse(txtTax.Text);
                    double xGstValue = (xAmount) * xGstPercentage / 100;

                    double xTotalAmount = xAmount + xGstValue;

                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {

                        int xDataGridStockId = Convert.ToInt32(dr.Cells["Id"].Value);
                        if (Convert.ToInt32(xStockId) == xDataGridStockId)
                        {
                            MessageBox.Show("Item entered already.");
                            return;
                        }
                    }
                    string xDiscountPercentage = txtDiscPercentage.Text == "0" ? "0.00" : Convert.ToDecimal(txtDiscPercentage.Text).ToString("#.##");
                    string xDiscountValue = txtDiscountValue.Text == "0" ? "0.00" : Convert.ToDecimal(txtDiscountValue.Text).ToString("#.##");
                    this.dataGridView1.Rows.Add(xStockId,
                    cmbItem.Text,
                    cmbBatch.Text,
                     Convert.ToDateTime(txtExpDate.Text).ToString("yyyy-MM-dd"),
                    txt_stock.Text,
                    txtPrice.Text,
                    txt_qty.Text,
                    xAmount,
                    xDiscountPercentage, xDiscountValue,
                    Convert.ToDecimal(xAmountAfterDiscount).ToString("#.##"),
                    Convert.ToDecimal(xGstPercentage).ToString("#.##"),
                    Convert.ToDecimal(xGstValue).ToString("#.##"),
                    Convert.ToDecimal(xTotalAmount).ToString("#.##"),
                   "DEL");

                    CalculateTotalAmount();
                    DataClear_Grid();

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
                    dataGridView1.Columns["Discercentage"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["AmountAfterDiscount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView1.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    cmbItem.Select();

                }
                else
                {
                    MessageBox.Show("Please Enter Lesser than Stock");
                    txt_qty.Focus();
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
            xCGST = (Math.Round(xGstValue / 2, 2));
            txtCGST.Text = xCGST.ToString();
            xSGST = (Math.Round(xGstValue / 2, 2));
            txtSGST.Text = xSGST.ToString();
            xTotalAmount = xAmount + xCGST + xSGST;
            txtTotalAmtBeforeTax.Text = xAmount.ToString();
            lbl_total_amount_value.Text = xTotalAmount.ToString();
        }

        private void DataClear_Grid()
        {
            cmbItem.Text = "Please select";
            cmbBatch.Text = "";
            txtExpDate.Text = "";
            txtPrice.Text = "";
            txt_qty.Text = "";
            txt_stock.Text = "";
            // cmbTax.Text = "Please select";
            txtDiscPercentage.Text = "";
            txtDiscountValue.Text = "";
        }

        private void DataClear()
        {
            txtTotalAmtBeforeTax.Text = "";
            txtCGST.Text = "";
            txtSGST.Text = "";
            lbl_total_amount_value.Text = "";
        }

        private void DataClear_Customer()
        {
            txtCustomerMobileNo.Text = "";
            rchCustomerAddress.Text = "";
        }

        private void cmb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBatch.Items.Clear();
            cmbBatch.Enabled=false;
            txtExpDate.Text = "";
            txt_stock.Text = "";
            txtPrice.Text = "";
            txtTax.Text = "";
            xDb.connection = new MySqlConnection(xDb.conString);
            string xItemNo = cmbItem.SelectedValue.ToString();
            if (xItemNo == "0")
            {
                return;
            }

            string selectQuery = "select s.stock,s.mrp," +
         " s.batch,s.expdate, " +
         " i.gst, " +
         " i.packdescription " +
         " from inv_stockentry s, " +
         " m_item i " +
         " where " +
         " i.itemno = s.itemno " +
         " and s.stock>0 and s.itemno = " + xItemNo;

            xDb.connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, xDb.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbBatch.Items.Add(reader[2].ToString());
       
            }
            xDb.connection.Close();
            cmbBatch.Enabled = true;

        }
        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtExpDate.Text = "";
            txt_stock.Text = "";
            txtPrice.Text = "";
            xDb.connection = new MySqlConnection(xDb.conString);
            string xItemNo = cmbItem.SelectedValue.ToString();
            string xBatch = cmbBatch.SelectedItem.ToString();
            if (xBatch == "")
            {
                return;
            }

            string selectQuery = "select s.stock,s.mrp," +
         " s.expdate, " +
         " i.gst, " +
         " i.packdescription " +
         " from inv_stockentry s, " +
         " m_item i " +
         " where " +
         " i.itemno = s.itemno " +
         " and s.itemno = " + xItemNo + " and s.batch='" + xBatch + "' and s.stock>0";

            xDb.connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, xDb.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                txt_stock.Text = reader[0].ToString();
                txtPrice.Text = reader[1].ToString();

                txtExpDate.Text = reader[2].ToString();
                txtTax.Text = reader[3].ToString();
            }
            xDb.connection.Close();
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
                double xPrice = double.Parse(dataGridView1.Rows[rowindex].Cells["Price"].Value.ToString());
                double xDiscountPercentage = double.Parse(dataGridView1.Rows[rowindex].Cells["DiscPercentage"].Value.ToString());
                double xGstPercentage = double.Parse(dataGridView1.Rows[rowindex].Cells["GstPercentage"].Value.ToString());
                double xAmount = xQty * xPrice;
                double xDiscountValue = xAmount * (xDiscountPercentage / 100);
                double xAmountAfterDiscount = xAmount - xDiscountValue;
                double xGstValue = (xAmountAfterDiscount) * xGstPercentage / 100;
                double xTotalAmount = xAmountAfterDiscount + xGstValue;
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

        private void mbtnSaveBill_Click(object sender, EventArgs e)
        {
            SaveData("S");
        }

        private void SaveData(string xBillStatus)
        {
            if (Int32.Parse(cmbCustomer.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Please Choose Ledger");
                return;
            }

            if (!(dataGridView1.Rows.Count > 0))
            {
                MessageBox.Show("Please add data");
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
                        int xItemNo = Convert.ToInt32(cmbItem.FindStringExact(dr.Cells["ItemName"].Value.ToString()));
                        double xQty = Convert.ToDouble(dr.Cells["Qty"].Value);
                        double xPrice = Convert.ToDouble(dr.Cells["Price"].Value);
                        double xGstPercentage = Convert.ToDouble(dr.Cells["GstPercentage"].Value);
                        double xUnitMrp = xPrice + (xPrice * xGstPercentage / 100);
                        string xBatch = dr.Cells["Batch"].Value.ToString();
                        string xQrySalesDetails = "insert into   inv_salesentry" +
                           "(salesinvoiceno,date,customerno,itemno,batchid," +
                           "dateexpired,qty,unitrate," +
                           "vat,discountpercentage," +
                           "createdason,updatedason,unitmrp) " +
                           "values(" + xSalesId + "," +
                             " '" + Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") + "'," +
                            " '" + Convert.ToInt32(cmbCustomer.SelectedValue.ToString()) + "'," +
                           " '" + xItemNo + "'," +
                            " '" + xBatch + "'," +
                            " '" + dr.Cells["ExpDate"].Value + "'," +
                           " " + Convert.ToDouble(dr.Cells["Qty"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["Price"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["GstPercentage"].Value) + "," +
                           " " + Convert.ToDouble(dr.Cells["DiscPercentage"].Value) + "," +
                           " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                           " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                           " " + xUnitMrp + " )";
                        xLessAmount += Convert.ToDouble(dr.Cells["DiscValue"].Value);

                        string xUpdateStockQry = "update inv_stockentry set " +
                            " stock = stock - " + xQty + " " +
                            " where itemno=" + xItemNo + " " +
                            " and batch = '" + xBatch + "' " +
                            " and mrp = '" + xPrice + "'";


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
                         + "," + xPrice
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
            dataGridView1.Rows.Clear();
            DataClear();
            DataClear_Customer();

            lblInvoiceNo.Text = xDb.GetMaxId("salesinvoiceno", "inv_salesentry1").ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.RowIndex == this.dataGridView1.NewRowIndex)
            //{
            //    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            //    e.CellStyle.ForeColor = Color.Red;
            //    switch (e.ColumnIndex)
            //    {
            //        case 0:
            //            e.Value = "Total";
            //            break;

            //        case 5:
            //            var sum = 0.0d;
            //            for (int i = 0; i < this.dataGridView1.NewRowIndex; i++)
            //            {
            //                var value = this.dataGridView1[5, i].Value;
            //                if (value is double)
            //                {
            //                    sum += ((double)value);
            //                }
            //            }
            //            e.Value = Math.Round(sum, 2);
            //            break;
            //            // Single line version of case 2 would be
            //            // e.Value = this.dataGridView1.Rows.Cast<DataGridViewRow>().Where(a => a.Index != a.DataGridView.NewRowIndex).Select(a => (double)a.Cells[2].Value).Sum().ToString("N2");
            //    }
            //}
            //int sum = 0;

            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{

            //    if (dataGridView1[1, i].Value != DBNull.Value)
            //        sum += (int)dataGridView1[1, i].Value;
            //}
            //dataGridView1[1, dataGridView1.Rows.Count - 1].Value = sum;
        }

        private void cmbCustomer_Leave(object sender, EventArgs e)
        {
            cmbItem.Select();
        }

       
        private void txtDiscPercentage_Leave(object sender, EventArgs e)
        {
            if (txt_qty.Text == "")
            {
                MessageBox.Show("Please Enter Qty ");
                txt_qty.Focus();
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

            double xAmount = double.Parse(txt_qty.Text) * double.Parse(txtPrice.Text);
            txtDiscountValue.Text = (xAmount * (double.Parse(txtDiscPercentage.Text) / 100)).ToString();

        }

        private void txtDiscountValue_Leave(object sender, EventArgs e)
        {

            if (txt_qty.Text == "")
            {
                MessageBox.Show("Please Enter Qty ");
                txt_qty.Focus();
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

            double xAmount = double.Parse(txt_qty.Text) * double.Parse(txtPrice.Text);
            txtDiscPercentage.Text = ((double.Parse(txtDiscountValue.Text) / xAmount) * 100).ToString();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "itemname Like '%" + txtSearch.Text + "%'";
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }
    }

}

