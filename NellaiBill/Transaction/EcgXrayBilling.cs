using CrystalDecisions.CrystalReports.Engine;
using NellaiBill.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Transaction
{
    public partial class EcgXrayBilling : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xEcgBillId ,xTestId ,xDoctorId,xPatientId, xFees;
        public EcgXrayBilling()
        {
            InitializeComponent();
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            SearchPatient search = new SearchPatient();
            search.ShowDialog();
            if (search.xPatientId.ToString() != "0")
            {

                txtPatientId.Text = search.xPatientId.ToString();
                txtPatientName.Text = search.xPatientName == null ? "" : search.xPatientName;
                rchPatientAddress.Text = search.xPatientAddress == null ? "" : search.xPatientAddress;
                txtUhid.Text = search.xUhid == null ? "" : search.xUhid;
            }
        }

   
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintBill(Convert.ToInt32(txtECGId.Text));
        }
        private void PrintBill(int billno)
        {
            ReportDocument reportDocument = new ReportDocument();
            GlobalClass globalClass = new GlobalClass();
            string path = globalClass.GetReportPath() + "rptEcgXrayBill.rpt";
            reportDocument.Load(path);
            reportDocument.SetParameterValue("billno", billno);
            reportDocument.PrintToPrinter(1, true, 0, 0);
        }

        private void ECGBilling_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSaveUpdate.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                btnPatientSearch.PerformClick();
            }
        }

        private void ECGBilling_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtECGId.Text = xDb.GetMaxId("billing_ecg_xray_id", "billing_ecg_xray").ToString();
            xDb.LoadComboBox("select ecg_xray_test_fees_id,test_name from m_ecg_xray_test_fees", cmbTest, "ecg_xray_test_fees_id", "test_name");
            xDb.LoadComboBox("select doctor_id,doctor_name from m_doctor", cmbDoctor, "doctor_id", "doctor_name");
            LoadGrid();
            cmbDoctor.SelectedIndex = 1;
            cmbSection.SelectedIndex = 0;
        }
        private void LoadGrid()
        {
            string xQry = "select b.billing_ecg_xray_id," +
                " b.date,p.patient_id,p.uhid,p.patient_name,p.patient_address,d.doctor_id,d.doctor_name," +
                " t.test_name,b.fees,b.section,b.created_on " +
                " from billing_ecg_xray b, m_doctor d, m_ecg_xray_test_fees t, m_patient_registration p " +
                " where b.patient_id = p.patient_id and b.test_id = t.ecg_xray_test_fees_id and " +
                " b.doctor_id = d.doctor_id  and b.date ='" + Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd") + "'";

            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void cmbTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFees();
        }
        private void GetFees()
        {

            int xTestId = Convert.ToInt32(cmbTest.SelectedValue.ToString());
            string xTestFees = xDb.GetTestFees(xTestId);
            txtFlimSize.Text= xDb.GetTestSize(xTestId);
            if (xTestFees != "")
            {
                txtFees.Text = xDb.GetTestFees(xTestId);
            }
            else
            {
                MessageBox.Show("Fees Empty !!! Please check");

            }

        }

        private void cmbTest_Leave(object sender, EventArgs e)
        {
            GetFees();
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtECGId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpBillDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPatientId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUhid.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPatientName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                rchPatientAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbDoctor.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbTest.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtFees.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                btnSaveUpdate.Text = "UPDATE";

            }
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            xDoctorId = Convert.ToInt32(cmbDoctor.SelectedValue.ToString());
            xEcgBillId = Convert.ToInt32(txtECGId.Text);
            xTestId = Convert.ToInt32(cmbTest.SelectedValue.ToString());

        
            if (xTestId == 0)
            {
                MessageBox.Show("Please Enter Test");
                cmbTest.Select();
                return;
            }
            if (txtPatientId.Text == "")
            {
                MessageBox.Show("Please Fill Patient");
                btnPatientSearch.Select();
                return;
            }
            if (xDoctorId==0)
            {
                MessageBox.Show("Please Fill Doctor");
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
            xPatientId = Convert.ToInt32(txtPatientId.Text);
            xFees = Convert.ToInt32(txtFees.Text);
            if (btnSaveUpdate.Text == "SAVE")
            {
                
                xQry = "insert into   billing_ecg_xray(date,patient_id,test_id,doctor_id," +
                    " fees,section,created_by,created_on) " +
                    " values('" + dtpBillDate.Value.ToString("yyyy-MM-dd") + "', " +
                    " " + xPatientId + " , " +
                    " " + xTestId + " , " +
                    " " + xDoctorId + " , " +
                    " " + xFees + " , " +
                    " '" + cmbSection.Text + "' , " +
                    " 'RECEPTION'," +
                    " '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' )";
                
            }
            else
            {
                xQry = "update billing_ecg_xray " +
                    " set test_id=" + xTestId + ", " +
                    " patient_id = " + xPatientId + ",  " +
                    " doctor_id = " + xDoctorId + ",  " +
                    " section = '" + cmbSection.Text + "',  " +
                    " fees = '" + xFees+ "'  " +
                    " where  billing_ecg_xray_id= " + xEcgBillId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
            DialogResult result = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PrintBill(xEcgBillId);
            }
            else if (result == DialogResult.No)
            {
                //...
            }
            
   
        }
        private void DataClear()
        {

            txtPatientId.Text = "";
            txtPatientName.Text = "";
            rchPatientAddress.Text = "";
            txtFees.Text = "";
            txtECGId.Text = xDb.GetMaxId("billing_ecg_xray_id", "billing_ecg_xray").ToString();
            cmbTest.Select();
            btnSaveUpdate.Text = "SAVE";
            cmbTest.SelectedIndex = 1;
        }
    }
}
