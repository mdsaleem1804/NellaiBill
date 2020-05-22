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

namespace NellaiBill.Master
{
    public partial class SetPrice : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xStockId;
        public SetPrice()
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
                double xStock = Convert.ToDouble(dr.Cells["stock"].Value);
                xStockValue+= xMrp* xStock;
            }
           // lblTotalStockValue.Text = xStockValue.ToString();
        }


        private void LoadGrid()
        {
            string xQuery = "select s.stockno,i.itemno,i.itemname,s.mrp,s.stock,s.batch from m_item i, inv_stockentry s where i.itemno = s.itemno";
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
                txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStock.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBatch.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                btnSaveUpdate.Enabled = true;
            }

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    string xUpdateStockQry = "update inv_stockentry " +
                   " set mrp=" + Convert.ToInt32(txtPrice.Text) + "," +
                   " stock=" + Convert.ToInt32(txtStock.Text) + "," +
                   " batch='" + txtBatch.Text + "'" +
                   " where  stockno= " + xStockId + "";
         
                    myCommand.CommandText = xUpdateStockQry;
                    myCommand.ExecuteNonQuery();

                    string xQryStockDetails = "insert into audit_stock" +
                                  " (audit_stock_itemno,audit_stock_qty," +
                                  " audit_stock_mrp,audit_stock_batch," +
                                  " audit_stock_datetime,audit_stock_mode)" +
                                  " values(" + txtItemName.Text 
                                  + ","  + Convert.ToInt32(txtStock.Text)
                                  + "," + Convert.ToInt32(txtPrice.Text)
                                  + ",'" + Convert.ToInt32(txtBatch.Text)
                                  + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") 
                                  + "','STOCK ADJUSTMENT')";

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
    }
}
