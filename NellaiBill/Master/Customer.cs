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
    public partial class Customer : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xCustomerId;
        public Customer()
        {
            InitializeComponent();
        }

        private void mBtnSaveUpdate_Click(object sender, EventArgs e)
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
                xQry = "insert into m_patient_registration (patient_id,patient_name,patient_address,patient_mobileno,created_by,created_on) " +
                    " values ( " + xCustomerId + ",'" + txtName.Text + "', '" + rchAddress.Text + "','" + txtMobileNo.Text + "'," +
                         " '" + xUser + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                         + "')";
            }
            else
            {
                xQry = "update m_patient_registration set " +
                    " patient_name = '" + txtName.Text + "', " +
                    " patient_address = '" + rchAddress.Text + "', " +
                    " patient_mobileno = '" + txtMobileNo.Text + "', updated_by = '" + xUser + "', updated_on = '" + xCurrentDateTime + "' " +
                    " where  patient_id= " + xCustomerId + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show("Customer Saved/Updated");
            xCustomerId = Convert.ToInt32(xDb.GetMaxId("patient_id", "m_patient_registration").ToString());
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

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadGrid();
            DataClear();
            xCustomerId = Convert.ToInt32(xDb.GetMaxId("patient_id", "m_patient_registration").ToString());
            this.KeyPreview = true;
        }
        private void LoadGrid()
        {
            string xQry = "select patient_id," +
                "patient_name as Name," +
                "patient_address as Address," +
                "patient_mobileno as Mobile " +
                "from m_patient_registration";

            xDb.LoadGrid(xQry, dataGridView1);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xCustomerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rchAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMobileNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            mBtnSaveUpdate.Text = "UPDATE";
            mBtnDelete.Enabled = true;
        }

        private void Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                mBtnSaveUpdate.PerformClick();
            }
        }
    }
}

