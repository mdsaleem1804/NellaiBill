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

namespace NellaiBill.Accounts
{
    public partial class AccountGroup : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xAccountGroupId;
        public AccountGroup()
        {
            InitializeComponent();
        }

        private void AccountGroup_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        private void LoadGrid()
        {
            string xQuery = "select account_group_id,account_group_name as  GROUPNAME " +
                " from account_group";
            xDb.LoadGrid(xQuery, dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            btnSaveUpdate.Text = "SAVE";
        }


        private void DataClear()
        {
            txtAccGroupName.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtAccGroupName.Focus();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataProcess();
        }
        public void DataProcess()
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");



            if (txtAccGroupName.Text == "")
            {
                MessageBox.Show("Please Enter  Name");
                txtAccGroupName.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into   account_group(account_group_name,created_by,created_on) " +
                    "values('" + txtAccGroupName.Text + "' ,'" + xUser + "','" + xCurrentDateTime + "' )";
            }
            else
            {
                xQry = "update account_group set " +
                    " account_group_name = '" + txtAccGroupName.Text + "',  " +
                    " updated_by = '" + xUser + "',  " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  account_group_id= " + xAccountGroupId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xAccountGroupId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtAccGroupName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
        }

        private void AccountGroup_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSaveUpdate.PerformClick();
            }
        }
    }
}
