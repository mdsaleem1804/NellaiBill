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
    public partial class frmGroup : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xCategoryId;
        int xGroupId;
        public frmGroup()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select itemcategoryno,itemcategoryname from m_itemcategory", cmbCategory, "itemcategoryno", "itemcategoryname");
            btnDelete.Enabled = false;
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
        private void LoadGrid()
        {
            string xQuery = "select c.itemcategoryno,g.itemgroupno,c.itemcategoryname,g.itemgroupname from m_itemcategory c,m_itemgroup g where c.itemcategoryno = g.itemcategoryno";
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
            xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            if (txtGroupName.Text == "")
            {
                MessageBox.Show("Please Enter  Name");
                txtGroupName.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into   m_itemgroup(itemcategoryno,itemgroupname) values(" + xCategoryId + ",'" + txtGroupName.Text + "' )";
            }
            else
            {
                xQry = "update m_itemgroup " +
                    " set itemcategoryno=" + xCategoryId + ", " +
                    " itemgroupname = '" + txtGroupName.Text + "'  " +
                    " where  itemgroupno= " + xGroupId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (xDb.CountRecord("select * from m_item where itemgroupno  = " + xGroupId + " ") >= 1)
            {
                MessageBox.Show("Selected Group mapped with other Item[Please delete item first]");
                return;
            }
            else
            {
                string xQry = "delete from m_itemgroup where  itemgroupno= " + xGroupId + "";
                xDb.DataProcess(xQry);
            }

            LoadGrid();
            DataClear();
        }

       
    }
}
