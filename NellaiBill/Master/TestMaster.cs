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
    public partial class TestMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xTestId;
        public TestMaster()
        {
            InitializeComponent();
        }


        private void TestMaster_Load(object sender, EventArgs e)
        {
        
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Width = 100;
        }
        private void LoadGrid()
        {
            string xQuery = "select * from m_test";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }


        private void DataClear()
        {
            txtTestName.Text = "";
            rchTextDescription.Text = "";
            btnSaveUpdate.Text = "SAVE";
            cmbTestGroup.SelectedIndex = 0;
            cmbTestMode.SelectedIndex = 0;
            txtTestName.Focus();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (cmbTestGroup.Text == "")
            {
                MessageBox.Show("Please Enter  Test Group");
                cmbTestGroup.Select();
                return;
            }
            if (txtTestName.Text == "")
            {
                MessageBox.Show("Please Enter  Name");
                txtTestName.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into   m_test(test_group,test_name,test_mode,test_description) " +
                    " values('" + cmbTestGroup.Text + "', " +
                    " '" + txtTestName.Text + "' , " +
                    " '" + cmbTestMode.Text + "' , " +
                    " '" + rchTextDescription.Text + "' )";
            }
            else
            {
                xQry = "update m_test " +
                    " set test_group='" + cmbTestGroup.Text + "', " +
                    " test_name = '" + txtTestName.Text + "',  " +
                    " test_mode = '" + cmbTestMode.Text + "',  " +
                    " test_description = '" + rchTextDescription.Text + "', " +
                    " test_name = '" + txtTestName.Text + "'  " +
                    " where  test_id= " + xTestId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xTestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbTestGroup.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTestName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbTestMode.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            rchTextDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                       btnSaveUpdate.Text = "UPDATE";
           
        }
    }
}
