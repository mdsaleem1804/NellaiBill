/* 
 * Item category table - Primary id set 
 * itemgroup table  used hardcoded
 * */
using NellaiBill.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NellaiBill.Master
{
    public partial class Category : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        string xTableName = "m_category";
        int xCategoryId;
 
   

        public Category()
        {
            InitializeComponent();
        }
        private void Category_Load(object sender, EventArgs e)
        {
          
            btnDelete.Enabled = false;
            LoadGrid();
            //DataClear();
            //dataGridView1.ReadOnly = true;
            //dataGridView1.Columns[0].Visible = false;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        public void DataProcess()
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please Enter Category Name");
                txtCategoryName.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into    " + xTableName + "(category_name,created_by,created_on) values( '" + txtCategoryName.Text + "','" + xUser+ "','" + xCurrentDateTime + "' )";
            }
            else
            {
                xQry = "update " + xTableName + " set " +
                    " category_name = '" + txtCategoryName.Text + "',  " +
                    " updated_by = '" + xUser + "',  " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  category_id= " + xCategoryId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataProcess();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (xDb.CountRecord("select * from m_group where category_id  = " + xCategoryId + " ") >= 1)
            {
                MessageBox.Show("Selected Category mapped with other Group[Please delete group first]");
                return;
            }
            else
            {
                string xQry = "delete from " + xTableName + " where  category_id= " + xCategoryId + "";
                xDb.DataProcess(xQry);
            }

            LoadGrid();
            DataClear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataClear();
            LoadGrid();
        }
        private void LoadGrid()
        {
            string xQuery = "select category_id,category_name as NAME from " + xTableName + " order by category_name";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }

        private void DataClear()
        {
            txtCategoryName.Text = "";
            btnSaveUpdate.Text = "SAVE";
            btnDelete.Enabled = false;
            txtCategoryName.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xCategoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCategoryName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
            btnDelete.Enabled = true;
        }

    }
}

