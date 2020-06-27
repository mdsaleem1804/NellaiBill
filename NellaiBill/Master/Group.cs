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
    public partial class Group : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xCategoryId;
        int xGroupId;
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select category_id,category_name from m_category", cmbCategory, "category_id", "category_name");
            btnDelete.Enabled = false;
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        private void LoadGrid()
        {
            string xQuery = "select c.category_id,g.group_id,c.category_name,g.group_name as GROUPNAME from m_category c,m_group g where c.category_id = g.category_id";
            cmbCategory.SelectedIndex = 1;
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }


        private void DataClear()
        {
            txtGroupName.Text = "";
            btnSaveUpdate.Text = "SAVE";
            btnDelete.Enabled = false;
            txtGroupName.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xCategoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            xGroupId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtGroupName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbCategory.SelectedIndex = cmbCategory.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            btnSaveUpdate.Text = "UPDATE";
            btnDelete.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataClear();
            LoadGrid();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataProcess();
        }
        public void DataProcess()
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            if (xCategoryId==0)
            {
                MessageBox.Show("Please Choose Group");
                cmbCategory.Focus();
                return;
            }
            
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("Please Enter  Name");
                txtGroupName.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into   m_group(category_id,group_name,created_by,created_on) values(" + xCategoryId + ",'" + txtGroupName.Text + "' ,'" + xUser + "','" + xCurrentDateTime + "' )";
            }
            else
            {
                xQry = "update m_group " +
                    " set category_id=" + xCategoryId + ", " +
                    " group_name = '" + txtGroupName.Text + "',  " +
                    " updated_by = '" + xUser + "',  " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  group_id= " + xGroupId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (xDb.CountRecord("select * from m_product where group_id  = " + xGroupId + " ") >= 1)
            {
                MessageBox.Show("Selected Group mapped with other Item[Please delete item first]");
                return;
            }
            else
            {
                string xQry = "delete from m_group where  group_id= " + xGroupId + "";
                xDb.DataProcess(xQry);
            }

            LoadGrid();
            DataClear();
        }

      
    }
}
