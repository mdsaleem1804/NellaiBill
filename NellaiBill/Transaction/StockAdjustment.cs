using MySql.Data.MySqlClient;
using NellaiBill.Common;
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
    public partial class StockAdjustment : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xStockId;
        int xProductId;
        int xOldQty = 0;
        string xOldBatch = "";
        public StockAdjustment()
        {
            InitializeComponent();
        }

        private void SetPrice_Load(object sender, EventArgs e)
        {
            btnSaveUpdate.Enabled = false;
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            //dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            double xStockValue = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                double xMrp = Convert.ToDouble(dr.Cells["mrp"].Value);
                double xStock = Convert.ToDouble(dr.Cells["qty"].Value);
                xStockValue += xMrp * xStock;
            }
            // lblTotalStockValue.Text = xStockValue.ToString();
        }


        private void LoadGrid()
        {
            string xQuery = "select s.stock_id,i.product_id,i.product_name,s.mrp,s.qty,s.batch_id,s.expiry_date  " +
                " from m_product i, stock s where i.product_id = s.product_id";
            xDb.LoadGrid(xQuery, dataGridView1);
        }
        private void DataClear()
        {
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtBatch.Text = "";
            txtStock.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                xStockId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                xProductId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                xOldQty = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                xOldBatch = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtBatch.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtExpDate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                btnSaveUpdate.Enabled = true;
            }

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("It will affect Old Batch Details in reference to purchase ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SaveData();
            }
            else if (result == DialogResult.No)
            {
                //...
            }


        }
        private void SaveData()
        {
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {

                    int xChangeQty = Convert.ToInt32(txtStock.Text);
                    int xCurrentQty = Convert.ToInt32(txtStock.Text);
                    decimal xMrp = Convert.ToDecimal(txtPrice.Text);
                    string xBatch = txtBatch.Text;
                    string xExpDate = txtExpDate.Text;
                    string xLogMessage = "STOCK ADJUSTMENT";

                    string xUpdateStockQry = "update stock " +
                   " set mrp=" + xMrp + "," +
                   " qty=" + xCurrentQty + "," +
                   " batch_id='" + xBatch + "'" +
                   " where  stock_id= " + xStockId + "";

                    myCommand.CommandText = xUpdateStockQry;
                    myCommand.ExecuteNonQuery();

                    string xUpdatePurchaseQry = "update purchase_details " +
                       " set    batch_id='" + xBatch + "'" +
                       " where  batch_id= '" + xOldBatch + "'";

                    myCommand.CommandText = xUpdatePurchaseQry;
                    myCommand.ExecuteNonQuery();

                    string xQryStockDetails = "insert into stock_history" +
                            "(product_id,old_qty,change_qty,current_qty," +
                            " mrp,batch_id,expiry_date,reason,created_by,created_on)" +
                             "values(" + xProductId + ", " + xOldQty + ", " +
                             " " + xChangeQty + "," + xCurrentQty + "," +
                             " " + xMrp + "," +
                             " '" + xBatch + "'," +
                             " '" + xExpDate + "'," +
                             " '" + xLogMessage + "'," +
                             " '" + LoginInfo.UserID + "'," +
                             " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                    myCommand.CommandText = xQryStockDetails;
                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    myConnection.Close();
                    btnSaveUpdate.Enabled = false;
                    LoadGrid();
                    DataClear();
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
                    myConnection.Close();
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataClear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "product_name Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void btnLoadSameBatch_Click(object sender, EventArgs e)
        {

            //string xQuery = "select s.stock_id,s.product_id,i.product_name,s.mrp,s.stock,s.batch_id,s.expiry_date,i.gst from stock s, m_product i  " +
            //    " where s.stock > 0 and s.product_id = i.product_id group by s.batch_id having count(s.batch_id) > 1 order by product_name";               
            //xDb.LoadGrid(xQuery, dataGridView2);
        }
    }
}
