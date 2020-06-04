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
    public partial class ScanFeesMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xTestFeesId = 0;
        public ScanFeesMaster()
        {
            InitializeComponent();
        }

        private void FeesMaster_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select scan_test_id,test_name from m_scan_test", cmbTest, "scan_test_id", "test_name");
            xDb.LoadComboBox("select doctor_id,doctor_name from m_doctor", cmbDoctor, "doctor_id", "doctor_name");
            LoadGrid();
            DataClear();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            int xScanTestId=Convert.ToInt32(cmbTest.SelectedValue.ToString());
            int xDoctorId = Convert.ToInt32(cmbDoctor.SelectedValue.ToString());
            if (xScanTestId == 0)
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
                xQry = "insert into   m_scan_test_fees(scan_test_id,doctor_id,fees) " +
                    " values(" + xScanTestId + ", " +
                    " " + xDoctorId + " , " +
                    " '" + txtFees.Text + "')";
            }
            else
            {
                xQry = "update m_scan_test_fees " +
                    " set scan_test_id=" + xScanTestId + ", " +
                    " doctor_id = " + xDoctorId + ",  " +
                    " fees = '" + txtFees.Text + "'  " +
                    " where  scan_test_fees_id= " + xTestFeesId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
            MessageBox.Show("Fees Inserted /Updated");
        }
        private void LoadGrid()
        {
            string xQuery = "select f.scan_test_fees_id,f.scan_test_id,f.doctor_id,d.doctor_name,t.test_name,f.fees " +
                " from m_scan_test_fees f,  m_doctor d,m_scan_test t where d.doctor_id = f.doctor_id and t.scan_test_id = f.scan_test_id";
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
            cmbTest.SelectedIndex = 0;
            cmbDoctor.SelectedIndex = 0;
            txtFees.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xTestFeesId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            cmbDoctor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbTest.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtFees.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";

        }

    }
}
