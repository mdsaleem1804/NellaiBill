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
    public partial class ScanTestMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xScanTestId;
        public ScanTestMaster()
        {
            InitializeComponent();
        }
        private void TestMaster_Load(object sender, EventArgs e)
        {     
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }
        private void LoadGrid()
        {
            string xQuery = "select scan_test_id,test_name as TestName from m_scan_test";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }
        private void DataClear()
        {
            txtTestName.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtTestName.Focus();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {        
            if (txtTestName.Text == "")
            {
                MessageBox.Show("Please Enter  Name");
                txtTestName.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into   m_scan_test(test_name) " +
                    " values('" + txtTestName.Text + "')";
            }
            else
            {
                xQry = "update m_scan_test " +
                    " set test_name = '" + txtTestName.Text + "'  " +
                    " where  m_scan_test_id= " + xScanTestId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xScanTestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTestName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";         
        }
    }
}
