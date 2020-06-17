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
    public partial class Employee : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }

        private void LoadGrid()
        {
            string xQuery = "select * from m_employee order by name";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }

        private void DataClear()
        {
            txtFullName.Text = "";
            txtMobileNo.Text = "";
            rchAddress.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            btnSaveUpdate.Text = "SAVE";
            btnDelete.Enabled = false;
            txtFullName.Focus();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataProcess();
        }
        public void DataProcess()
        {
            if (txtFullName.Text == "")
            {
                MessageBox.Show("Please Enter  Name");
                txtFullName.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                int xDepartmentId = 1;
                xQry = "insert into m_employee " +
                    "  (name,mobileno,address,username,password,department_id) " +
                    "  values( " +
                    " '" + txtFullName.Text + "' ," +
                    " '" + txtMobileNo.Text + "' ," +
                    " '" + rchAddress.Text + "' ," +
                    " '" + txtUserName.Text + "' ," +
                    " '" + txtPassword.Text + "' ," +
                    " '" + xDepartmentId + "' " +
                    " )";
            }
            else
            {
                //xQry = "update " + xTableName + " set category_name = '" + txtCategoryName.Text + "'  where  category_id= " + xCategoryId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }
    }
}
