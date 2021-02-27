using CrystalDecisions.CrystalReports.Engine;
using NellaiBill.Common;
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
    public partial class NewPatient : Form
    {

        DatabaseConnection xDb = new DatabaseConnection();
        private string xUserName = LoginInfo.UserID;
        public NewPatient()
        {
            InitializeComponent();
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 1;
            txtMobileNo.MaxLength = 10;
            DataClear();
            LoadGrid();
            lblId.Text = "User Id";
            lblSearch.Text = "Search Id";
            cmbGender.SelectedIndex = 1;
            this.KeyPreview = true;
            dtpDob.Value= new DateTime(2000, 01, 01);
            dtpDob.MaxDate = DateTime.Now;
        }

        private void loadFormBasedOnMissedUHID()
        {
            if (cmbUhidSelection.Text == "NEW")
            {
                txtPatientId.Text = xDb.GetMaxId("patient_id", "m_patient_registration").ToString();
                GenerateUHID();
            }
            else if (cmbUhidSelection.Text == "OLD")
            {
                txtPatientId.Text = "";
                txtPatientId.Enabled = true;
            }
        }
        private void GenerateUHID()
        {
            string LeadingZero = txtPatientId.Text.PadLeft(6, '0');
            String xAfterAddingZero = LeadingZero.ToString();

            for (int i = 2; i <= xAfterAddingZero.Length - 1; i += 2)
            {
                xAfterAddingZero = xAfterAddingZero.Insert(i, "-");
                i++;
            }
            string Month = DateTime.Now.ToString("MM");
            string Year = DateTime.Now.ToString("yy");
            if (txtPatientId.Text != "")
            {
                int xPatientId = Convert.ToInt32(txtPatientId.Text.ToString());
                if (xPatientId > 12000)
                {
                    txtUhid.Text = xAfterAddingZero + "-" + Month + "" + Year;
                }
                else
                {
                    txtUhid.Text = xAfterAddingZero;
                }
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPatientId.Text == "")
            {
                MessageBox.Show("Something Wrong !! Patient Id");
                txtPatientId.Focus();
                return;
            }
            if (txtUhid.Text == "")
            {
                MessageBox.Show("Something Wrong !! Uhid");
                txtUhid.Focus();
                return;
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Please Choose Name");
                txtName.Focus();
                return;
            }
            if (txtMobileNo.Text == "")
            {
                MessageBox.Show("Please Choose MobileNo");
                txtMobileNo.Focus();
                return;
            }
            if (cmbGender.Text == "")
            {
                MessageBox.Show("Please Choose Gender");
                cmbGender.Select();
                return;
            }

            if (txtAge.Text == "")
            {
                MessageBox.Show("Please Enter Dob");
                txtAge.Select();
                return;
            }
            String xGender = "M";
            if (cmbGender.Text == "Male")
            {
                xGender = "M";
            }
            else
            {
                xGender = "F";
            }
            string xQry = "";
            if (btnSave.Text == "SAVE(CTRL+S)")
            {

                xQry = "insert into m_patient_registration " +
                    " (patient_id,uhid,patient_name,age,gender,date_of_birth,patient_address,patient_mobileno,next_of_kin,date_of_reg,created_by,created_on) " +
                    " values ( " + txtPatientId.Text + ", " +
                    " '" + txtUhid.Text + "'," +
                    " '" + txtName.Text + "'," +
                    " " + txtAge.Text + "," +
                    " '" + xGender + "'," +
                    " '" + dtpDob.Value.ToString("yyyy-MM-dd") + "'," +
                    " '" + rchAddress.Text + "', " +
                    " '" + txtMobileNo.Text + "', " +
                    "'" + rchNextOfKin.Text + "'," +
                    " '" + dtpEntryDate.Value.ToString("yyyy-MM-dd") + "'," +
                    " '" + xUserName + "'," +
                    " '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "' )";
            }

            else
            {
                xQry = "update m_patient_registration set " +
                    " uhid = '" + txtUhid.Text + "', " +
                    " patient_name = '" + txtName.Text + "', " +
                    " patient_address = '" + rchAddress.Text + "', " +
                     " gender = '" + xGender + "', " +
                     " date_of_birth = '" + dtpDob.Value.ToString("yyyy-MM-dd") + "', " +
                     "next_of_kin = '" + rchNextOfKin.Text + "', " +
                     "patient_mobileno = '" + txtMobileNo.Text + "'," +
                     "age = " + txtAge.Text + "," +
                     "updated_by = '" + xUserName + "'," +
                     "updated_on = '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                    " where  patient_id= " + txtPatientId.Text + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show("Saved/Updated");
            LoadGrid();
            DataClear();

        }
        private void LoadGrid()
        {
            string xQry = "select patient_id as PATIENTID,uhid as UHID," +
                "patient_name as NAME,patient_address as ADDRESS,patient_mobileno as MOBILENO," +
                "age as AGE,gender as GENDER,date_of_birth as DOB,next_of_kin as RELATIONSHIP from m_patient_registration order by patient_id desc";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 250;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].Width = 50;
        }
        private void DataClear()
        {
            txtName.Text = "";
            rchAddress.Text = "";
            rchNextOfKin.Text = "";
            txtAge.Text = "";
            txtPatientId.Text = xDb.GetMaxId("patient_id", "m_patient_registration").ToString();
            txtUhid.Text = "";
            txtMobileNo.Text = "";
            txtName.Focus();
            txtPatientId.MaxLength = 6;
            cmbUhidSelection.Text = "NEW";
            loadFormBasedOnMissedUHID();
        }
        private void cmbUhidSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFormBasedOnMissedUHID();
        }

        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {

            GenerateUHID();
        }

        private void dtpDob_Leave(object sender, EventArgs e)
        {
            GetAgeFromDOB();
        }

        private void GetAgeFromDOB()
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(dtpDob.Value).Ticks).Year - 1;
            txtAge.Text = Years.ToString();
            DateTime PastYearDate = dtpDob.Value.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = Now.Subtract(PastYearDate).Hours;
            int Minutes = Now.Subtract(PastYearDate).Minutes;
            int Seconds = Now.Subtract(PastYearDate).Seconds;
            //return String.Format("Age: {0} Year(s) {1} Month(s) {2} Day(s) {3} Hour(s) {4} Second(s)",
            //Years, Months, Days, Hours, Seconds);
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSave.Text = "UPDATE";
                txtPatientId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUhid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                rchAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMobileNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbGender.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                string xDateFromGrid = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                DateTime  xDob=  Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                if(xDob == DateTime.MinValue)
                {
                    dtpDob.Value = new DateTime(2000, 01, 01);
                }
                else { 
                    dtpDob.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()); 
                }
               
                rchNextOfKin.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
              
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "patient_name Like '%" + txtSearch.Text + "%' OR uhid LIKE '%" + txtSearch.Text + "%' OR patient_mobileno LIKE '%" + txtSearch.Text + "%' OR patient_address LIKE '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int xPatientId = Convert.ToInt32(txtPatientId.Text);
            if (xPatientId <= 12000)
            {
                MessageBox.Show("Sorry - Printing is temporarily blocked before 12001");
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Data is not available");
                txtName.Focus();
                return;
            }

            ReportDocument reportDocument = new ReportDocument();
            GlobalClass globalClass = new GlobalClass();
            string path = globalClass.GetReportPath() + "rptPatientInformation.rpt";
            reportDocument.Load(path);
            reportDocument.SetParameterValue("PatientId", xPatientId);
            reportDocument.PrintToPrinter(1, true, 0, 0);
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
            GetAgeFromDOB();
        }

        private void NewPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
            }
        }

        private static void AcceptNumeric(KeyPressEventArgs e)
        {
            //We only want to allow numeric style chars
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //Setting e.Handled cancels the keypress event, so the key is not entered
                e.Handled = true;
            }
        }

        private void txtPatientId_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptNumeric(e);
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptNumeric(e);
        }
    }
}
