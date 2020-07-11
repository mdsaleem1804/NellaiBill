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
    public partial class Supplier : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xSupplierId;
        public Supplier()
        {
            InitializeComponent();
        }

        private void Ledger_Load(object sender, EventArgs e)
        {
            LoadGrid();
            DataClear();
            this.KeyPreview = true;
            xSupplierId = Convert.ToInt32(xDb.GetMaxId("supplier_id", "m_supplier").ToString());
        }
        private void LoadGrid()
        {
            string xQry = "select supplier_id," +
                "name as Name," +
                "address as Address," +
                "mobile_no as Mobile " +
                "from m_supplier";

            xDb.LoadGrid(xQry, dataGridView1);

        }
        private void mBtnSave_Click(object sender, EventArgs e)
        {
            string xQry = "";
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Choose Name");
                return;
            }
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (mBtnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into m_supplier (supplier_id,name,address,mobile_no,created_by,created_on) " +
                    " values ( " + xSupplierId + ",'" + txtName.Text + "', '" + rchAddress.Text + "','" + txtMobileNo.Text + "'," +
                         " '" + xUser + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                         + "')";
            }
            else
            {
                xQry = "update m_supplier set " +
                    " name = '" + txtName.Text + "', " +
                    " address = '" + rchAddress.Text + "', " +
                    " mobile_no = '" + txtMobileNo.Text + "', updated_by = '" + xUser + "', updated_on = '" + xCurrentDateTime + "' " +
                    " where  supplier_id= " + xSupplierId + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show("Supplier Saved/Updated");
            xSupplierId = Convert.ToInt32(xDb.GetMaxId("supplier_id", "m_supplier").ToString());
            LoadGrid();
            DataClear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xSupplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rchAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMobileNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mBtnSaveUpdate.Text = "UPDATE";
            mBtnDelete.Enabled = true;
        }

        private void mBtnDelete_Click(object sender, EventArgs e)
        {
            string xTableName = "purchase";
            string xColumnName = "supplier_id";
            if (xDb.CountRecord("select * from " + xTableName + " where " + xColumnName + " = " + xSupplierId + " ") >= 1)
            {
                MessageBox.Show("Selected supplier  is  mapped with other transaction");
                return;
            }
            else
            {
                string xQry = "delete from m_supplier  where  supplier_id= " + xSupplierId + "";
                xDb.DataProcess(xQry);
            }
            MessageBox.Show("Supplier Deleted");
            LoadGrid();
            DataClear();
        }

        private void DataClear()
        {
            txtName.Text = "";
            rchAddress.Text = "";
            txtMobileNo.Text = "";
            mBtnSaveUpdate.Text = "SAVE";
            mBtnDelete.Enabled = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }

        private void Supplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                mBtnSaveUpdate.PerformClick();
            }
        }
    }
}
