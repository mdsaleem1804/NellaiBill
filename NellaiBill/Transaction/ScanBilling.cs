using CrystalDecisions.CrystalReports.Engine;
using NellaiBill.Master;
using NellaiBill.Search;
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
 
    public partial class ScanBilling : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xScanId, xTestId, xDoctorId, xPatientId, xFees;
        public ScanBilling()
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

        private void ScanBilling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.D)
            {
                btnDoctorSearch.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                btnPatientSearch.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSaveUpdate.PerformClick();
            }
        }

        private void ScanBilling_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtScanId.Text= xDb.GetMaxId("scan_id", "billing_scan").ToString();
            LoadGrid();
        }

        private void btnDoctorSearch_Click(object sender, EventArgs e)
        {
            SearchScanDoctorFees search = new SearchScanDoctorFees();
            search.ShowDialog();
            if (search.xDoctorId.ToString() != "0")
            {
                txtDoctorName.Text = search.xDoctorName.ToString();
                txtDoctorId.Text = search.xDoctorId.ToString();
                txtTestId.Text = search.xTestId.ToString();
                txtTextName.Text = search.xTestName.ToString();
                txtFees.Text = search.xFees.ToString();
            }
        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (txtPatientId.Text == "")
            {
                MessageBox.Show("Please Fill Patient");
                btnPatientSearch.Select();
                return;
            }

            if (txtTestId.Text == "")
            {
                MessageBox.Show("Please Enter Test");
                btnDoctorSearch.Select();
                return;
            }
           
            if (txtDoctorId.Text == "")
            {
                MessageBox.Show("Please Fill Doctor");
                btnDoctorSearch.Select();
                return;
            }
            if (txtFees.Text == "")
            {
                MessageBox.Show("Please Enter Fees");
                txtFees.Focus();
                return;
            }
            xTestId = Convert.ToInt32(txtTestId.Text);
            xPatientId = Convert.ToInt32(txtPatientId.Text);
            xScanId = Convert.ToInt32(txtScanId.Text);
            xDoctorId = Convert.ToInt32(txtDoctorId.Text);
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");


           
            string xQry = "";
            xFees = Convert.ToInt32(txtFees.Text);
            if (btnSaveUpdate.Text == "SAVE")
            {

                xQry = "insert into   billing_scan(date,patient_id,doctor_id,test_id,fees," +
                    " created_by,created_on) " +
                    " values('" + dtpBillDate.Value.ToString("yyyy-MM-dd") + "', " +
                    " " + xPatientId + " , " +
                    " " + xDoctorId + " , " +
                    " " + xTestId + " , " +
                    " " + xFees + " , " +
                    " 'RECEPTION'," +
                    "  '" + xCurrentDateTime + "')";
            }
            else
            {
                xQry = "update billing_scan " +
                    " set test_id=" + xTestId + ", " +
                    " patient_id = " + xPatientId + ",  " +
                    " doctor_id = " + xDoctorId + ",  " +
                    " fees = '" + xFees + "', " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  scan_id= " + xScanId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
            DialogResult result = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PrintBill(xScanId);
            }
            else if (result == DialogResult.No)
            {
                //...
            }

        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
        }

        private void DataClear()
        {
            txtPatientId.Text = "";
            txtPatientName.Text = "";
            rchPatientAddress.Text = "";
            txtUhid.Text = "";
            txtDoctorId.Text = "";
            txtDoctorName.Text = "";
            txtTestId.Text = "";
            txtTextName.Text = "";
            txtFees.Text = "";
            txtScanId.Text = xDb.GetMaxId("scan_id", "billing_scan").ToString();
        }
        private void LoadGrid()
        {
            string xQry = "select b.scan_id," +
                 " b.date,p.patient_id,p.uhid,p.patient_name,p.patient_address,d.doctor_id,d.doctor_name," +
                 " b.test_id,t.test_name,b.fees,b.created_on " +
                 " from billing_scan b, m_doctor d, m_scan_test t, m_patient_registration p " +
                 " where b.patient_id = p.patient_id and b.test_id = t.scan_test_id and " +
                 " b.doctor_id = d.doctor_id  and b.date ='" + Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd") + "'";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtScanId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpBillDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPatientId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUhid.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPatientName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                rchPatientAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDoctorId.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDoctorName.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtTestId.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtTextName.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtFees.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                btnSaveUpdate.Text = "UPDATE";
            }
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
    }
}
