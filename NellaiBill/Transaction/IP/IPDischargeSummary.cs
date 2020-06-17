using CrystalDecisions.CrystalReports.Engine;
using NellaiBill.Common;
using NellaiBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Transaction.IP
{
    public partial class IPDischargeSummary : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public IPDischargeSummary()
        {
            InitializeComponent();
        }

        private void IPDischargeSummary_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBoxData("select ipno,admitted_by from ip_admission where is_paid=0", cmbIPNo);
            LoadGrid();
            txtDischargeNo.Text = xDb.GetMaxId("ip_discharge_entry_id", "ip_discharge_entry").ToString();
            cmbIPNo.SelectedIndex=0;
            this.KeyPreview = true;
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if(cmbIPNo.Text=="")
            {
                MessageBox.Show("Choose IpNo");
                return;
            }
            if (rchAdmissionCondition.Text == "")
            {
                MessageBox.Show("Please Fill Data");
                rchAdmissionCondition.Focus();
                return;
            }
            if (rchInvestigationDone.Text == "")
            {
                MessageBox.Show("Please Fill Data");
                rchInvestigationDone.Focus();
                return;
            }
            if (rchTreatmentGiven.Text == "")
            {
                MessageBox.Show("Please Fill Data");
                rchTreatmentGiven.Focus();
                return;
            }
            if (rchClinicalCourse.Text == "")
            {
                MessageBox.Show("Please Fill Data");
                rchClinicalCourse.Focus();
                return;
            }
            if (rchDischargeCondition.Text == "")
            {
                MessageBox.Show("Please Fill Data");
                rchDischargeCondition.Focus();
                return;
            }
            if (rchDischargeAdvice.Text == "")
            {
                MessageBox.Show("Please Fill Data");
                rchDischargeAdvice.Focus();
                return;
            }
            string xQry = "";
           int  xDischargeId = Convert.ToInt32(txtDischargeNo.Text);
            if (btnSaveUpdate.Text == "SAVE")
            {

                xQry = "insert into   ip_discharge_entry(date,ipno,admission_condition,investigation_done,treatement_given," +
                    " clinical_course,discharge_condition,discharge_advice,created_by,created_on)" +
                    " values('" + dtpBillDate.Value.ToString("yyyy-MM-dd") + "', " +
                    " '" + cmbIPNo.Text + "' , " +
                    " '" + rchAdmissionCondition.Text + "' , " +
                    " '" + rchInvestigationDone.Text + "' , " +
                    " '" + rchTreatmentGiven.Text + "' , " +
                    " '" + rchClinicalCourse.Text + "' , " +
                    " '" + rchDischargeCondition.Text + "' , " +
                    " '" + rchDischargeAdvice.Text + "' , " +
                    " '" + LoginInfo.UserID + "' , " +
                    " '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "' )";
            }
            else
            {
                xQry = "update ip_discharge_entry " +
                    " set admission_condition='" + rchAdmissionCondition.Text + "', " +
                    " investigation_done = '" + rchInvestigationDone.Text + "',  " +
                    " treatement_given = '" + rchTreatmentGiven.Text + "',  " +
                    " clinical_course = '" + rchClinicalCourse.Text + "',  " +
                    " discharge_condition = '" + rchDischargeCondition.Text + "',  " +
                    " discharge_advice = '" + rchDischargeAdvice.Text + "',  " +
                    " updated_by = '" + LoginInfo.UserID + "' , " +
                    " updated_on = '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "'  " +
                    " where  ip_discharge_entry_id= " + xDischargeId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
            DialogResult result = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                 PrintBill(xDischargeId);
            }
            else if (result == DialogResult.No)
            {
                //...
            }
        }
        private void PrintBill(int billno)
        {
            ReportDocument reportDocument = new ReportDocument();
            GlobalClass globalClass = new GlobalClass();
            string path = globalClass.GetReportPath() + "rptDischargeBill.rpt";
            reportDocument.Load(path);
            reportDocument.SetParameterValue("billno", billno);
            reportDocument.PrintToPrinter(1, true, 0, 0);
        }

        private void DataClear()
        {
            rchAdmissionCondition.Text = "";
            rchInvestigationDone.Text = "";
            rchTreatmentGiven.Text = "";
            rchClinicalCourse.Text = "";
            rchDischargeCondition.Text = "";
            rchDischargeAdvice.Text = "";
            txtDischargeNo.Text = xDb.GetMaxId("ip_discharge_entry_id", "ip_discharge_entry").ToString();
        }
        private void LoadGrid()
        {
            string xQry = "select ip_discharge_entry_id,date,ipno," +
                " admission_condition,investigation_done,treatement_given,clinical_course,discharge_condition,discharge_advice " +
                " from ip_discharge_entry";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["ip_discharge_entry_id"].Visible = false;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;


        }

        private void cmbIPNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPDetailModel ipResponse = xDb.GetIpDetailsFromIpNo(Convert.ToInt32(cmbIPNo.Text));
            PatientResponseModel patientResponse = xDb.GetPatientFromPatientId(ipResponse.PatientId);
            DoctorResponseModel doctorResponse = xDb.GetDoctorFromDoctorId(ipResponse.DoctorId);

            txtPatientName.Text = patientResponse.PatientName.ToString();
            txtDoctorName.Text = doctorResponse.DoctorName;
            txtCaseType.Text = xDb.GetCaseTypeNameFromCaseTypeId(ipResponse.CaseTypeId);

        }

        private void IPDischargeSummary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSaveUpdate.PerformClick();
            }
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDischargeNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpBillDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                rchAdmissionCondition.Text = dataGridView1.Rows[e.RowIndex].Cells["admission_condition"].Value.ToString();
                rchInvestigationDone.Text = dataGridView1.Rows[e.RowIndex].Cells["investigation_done"].Value.ToString();
                rchTreatmentGiven.Text = dataGridView1.Rows[e.RowIndex].Cells["treatement_given"].Value.ToString();
                rchClinicalCourse.Text = dataGridView1.Rows[e.RowIndex].Cells["clinical_course"].Value.ToString();
                rchDischargeCondition.Text = dataGridView1.Rows[e.RowIndex].Cells["discharge_condition"].Value.ToString();
                rchDischargeAdvice.Text = dataGridView1.Rows[e.RowIndex].Cells["discharge_advice"].Value.ToString();            
                btnSaveUpdate.Text = "UPDATE";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int xDischargeId = Convert.ToInt32(txtDischargeNo.Text);
            PrintBill(xDischargeId);
        }
    }

}

