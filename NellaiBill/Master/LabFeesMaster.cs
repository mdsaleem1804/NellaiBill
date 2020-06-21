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
    public partial class LabFeesMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xLabFeesId = 0;
        public LabFeesMaster()
        {
            InitializeComponent();
        }

        private void LabFeesMaster_Load(object sender, EventArgs e)
        {
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }
        private void LoadGrid()
        {
            string xQuery = "select lab_test_fees_id,test_name as TestName," +
                " test_description as TestDescription ,amount as Amount from m_lab_test_fees";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }
        private void DataClear()
        {
            txtTestName.Text = "";
            txtTestDescription.Text = "";
            txtAmount.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtTestName.Focus();
            xLabFeesId = xDb.GetMaxId("lab_test_fees_id", "m_lab_test_fees");
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
         

            if (txtTestName.Text == "")
            {
                MessageBox.Show("Please Enter TestName");
                txtTestName.Focus();
                return;
            }
            if (txtTestDescription.Text == "")
            {
                MessageBox.Show("Please Enter TestDescription");
                txtTestDescription.Focus();
                return;
            }
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Enter TestAmount");
                txtAmount.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                
                xQry = "insert into   m_lab_test_fees(lab_test_fees_id,test_name,test_description,amount) " +
                    " values(" + xLabFeesId + ", " +
                    " '" + txtTestName.Text + "' , " +
                    " '" + txtTestDescription.Text + "' , " +
                    " '" + txtAmount.Text + "')";
            }
            else
            {
                xQry = "update m_lab_test_fees " +
                    " set test_name='" + txtTestName.Text + "', " +
                    " test_description = '" + txtTestDescription.Text + "',  " +
                    " amount = '" + txtAmount.Text + "'  " +
                    " where  lab_test_fees_id= " + xLabFeesId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
            MessageBox.Show("Lab Fees Inserted /Updated");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                xLabFeesId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtTestName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTestDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnSaveUpdate.Text = "UPDATE";
            }
        }
    }
}
