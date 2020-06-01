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
    public partial class FeesMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xTestFeesId = 0;
        public FeesMaster()
        {
            InitializeComponent();
        }

        private void FeesMaster_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select test_id,test_name from m_test", cmbTest, "test_id", "test_name");
            xDb.LoadComboBox("select doctor_id,doctor_name from m_doctor", cmbDoctor, "doctor_id", "doctor_name");
            LoadGrid();
            DataClear();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            int xTestId=Convert.ToInt32(cmbTest.SelectedValue.ToString());
            int xDoctorId = Convert.ToInt32(cmbDoctor.SelectedValue.ToString());
            if (xTestId == 0)
            {
                MessageBox.Show("Please Enter Test");
                cmbTest.Select();
                return;
            }
            if (xDoctorId == 0)
            {
                MessageBox.Show("Please Enter Doctor");
                cmbDoctor.Select();
                return;
            }
            if (txtFees.Text == "")
            {
                MessageBox.Show("Please Enter Fees");
                txtFees.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into   m_test_fees(test_id,doctor_id,fees) " +
                    " values(" + xTestId + ", " +
                    " " + xDoctorId + " , " +
                    " '" + txtFees.Text + "')";
            }
            else
            {
                xQry = "update m_test_fees " +
                    " set test_id=" + xTestId + ", " +
                    " doctor_id = " + xDoctorId + ",  " +
                    " fees = '" + txtFees.Text + "'  " +
                    " where  test_fees_id= " + xTestFeesId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
            MessageBox.Show("Fees Inserted /Updated");
        }
        private void LoadGrid()
        {
            string xQuery = "select f.test_fees_id,f.test_id,f.doctor_id,d.doctor_name,t.test_name,f.fees " +
                " from m_test_fees f, m_doctor d, m_test t " +
                " where d.doctor_id = f.doctor_id and t.test_id = f.test_id";
            xDb.LoadGrid(xQuery, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            btnSaveUpdate.Text = "SAVE";
        }


        private void DataClear()
        {
            txtFees.Text = "";
            btnSaveUpdate.Text = "SAVE";
            cmbTestGroup.SelectedIndex = 0;
            cmbTest.SelectedIndex = 0;
            cmbDoctor.SelectedIndex = 0;
            txtFees.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xTestFeesId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //cmbDoctor.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtTestName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbDoctor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbTest.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtFees.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";

        }

        private void cmbTestGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTestGroup.Text != "ALL")
            {
                String xSelectedTestGroup = cmbTestGroup.Text;
                xDb.LoadComboBox("select test_id,test_name from m_test " +
                    " where test_group='" + xSelectedTestGroup + "'", cmbTest, "test_id", "test_name");
            }
        }
    }
}
