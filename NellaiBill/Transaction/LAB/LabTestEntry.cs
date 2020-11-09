using MySql.Data.MySqlClient;
using NellaiBill.Models;
using NellaiBill.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Transaction.LAB
{
    public partial class LabTestEntry : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public LabTestEntry()
        {
            InitializeComponent();
        }

        private void LabTestEntry_Load(object sender, EventArgs e)
        {
            DataClear();
            this.KeyPreview = true;
            LoadGrid();
        }
        private void LoadGrid()
        {
            //string xQry = "select bl.lab_id,p.patient_name,bl.date,ltf.test_name,ltf.test_description,bld.patient_test_details from billing_lab_details bld, " +
            //" m_lab_test_fees ltf, billing_lab bl, m_patient_registration p " +
            //" where bld.test_id = ltf.lab_test_fees_id and bl.lab_id = bld.lab_id and bl.patient_id = p.patient_id";
            //xDb.LoadGrid(xQry, dataGridView1);
            //dataGridView1.ReadOnly = true;
            ////dataGridView1.Columns[0].Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtLabId.Text == "")
            {
                MessageBox.Show("Please Enter Lab Id");
                txtLabId.Focus();
                return;
            }

            LabResponseModel labResponse = xDb.GetLabRecordFromLabId(Convert.ToInt32(txtLabId.Text));
            PatientResponseModel patientResponse = xDb.GetPatientFromPatientId(labResponse.PatientId);
            DoctorResponseModel doctorResponse = xDb.GetDoctorFromDoctorId(labResponse.DoctorId);
            txtBillDate.Text = labResponse.BillDate.ToString();
            txtPatientId.Text = patientResponse.PatientId.ToString();
            txtPatientName.Text = patientResponse.PatientName.ToString();
            txtUhid.Text = patientResponse.UHID.ToString();
            txtDoctorName.Text = doctorResponse.DoctorName;

            string xQry = "select bld.lab_id,bld.test_id,ltf.test_name as TestName, " +
                " ltf.test_description as TestDescription, " +
                " bld.patient_test_details as PatientTestDetails  " +
                " from billing_lab_details bld, " +
                " m_lab_test_fees ltf, billing_lab bl" +
                " where bld.test_id = ltf.lab_test_fees_id " +
                " and bl.lab_id = bld.lab_id and bld.lab_id= " + txtLabId.Text;
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Width = 200;
            txtLabId.Enabled = false;
            btnUpdate.Enabled = true;
            btnView.Enabled = true;
        }

        private void DataClear()
        {
            txtLabId.Text = "";
            txtBillDate.Text = "";
            txtPatientId.Text = "";
            txtUhid.Text = "";
            txtPatientName.Text = "";
            txtDoctorName.Text = "";
            btnEdit.Enabled = true;
            btnView.Enabled = false;
            btnUpdate.Enabled = false;
            txtLabId.Enabled = true;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                string xPatientTestDetails = dr.Cells[4].Value.ToString();
                if (xPatientTestDetails == "")
                {
                    MessageBox.Show("Fill all patient test details");
                    return;
                }
            }
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {
                        int xLabId = Convert.ToInt32(dr.Cells[0].Value);
                        int xTestId = Convert.ToInt32(dr.Cells[1].Value);
                        string xPatientTestDetails = dr.Cells[4].Value.ToString();
                        string xQryLabBillDetails = "update  billing_lab_details " +
                            " set patient_test_details = '" + xPatientTestDetails + "' where lab_id=" + xLabId + " and test_id=" + xTestId + "";
                        myCommand.CommandText = xQryLabBillDetails;
                        myCommand.ExecuteNonQuery();
                    }

                    myTrans.Commit();
                    MessageBox.Show("Record Updated Succesfully ");
                    btnView.PerformClick();
                    DataClear();
                    // dataGridView1.Rows.Clear();
                    dataGridView1.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record not saved - Error Occured" + ex.ToString());
                    myTrans.Rollback();
                }
                finally
                {
                    myCommand.Dispose();
                    myTrans.Dispose();
                    xDb.connection.Close();
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LabPatientTestReport report = new LabPatientTestReport(Convert.ToInt32(txtLabId.Text));
            report.ShowDialog();
        }
    }
}
