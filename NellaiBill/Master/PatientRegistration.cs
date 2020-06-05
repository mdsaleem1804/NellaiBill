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
        public NewPatient()
        {
            InitializeComponent();
        }

        private void NewPatient_Load(object sender, EventArgs e)
        {
            DataClear();
            LoadGrid();
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
            txtUhid.Text = xAfterAddingZero +"-" + Month+ "" +Year;
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
            

            string xQry = "";
            if (btnSave.Text == "SAVE(CTRL+S)")
            {
                String xGender = "M";
                if (cmbGender.Text== "Male")
                {
                    xGender = "M";
                }else
                {
                    xGender = "F";
                }
                xQry = "insert into m_patient_registration " +
                    " (patient_id,uhid,patient_name,age,gender,patient_address,patient_mobileno) " +
                    " values ( " + txtPatientId.Text + ", " +
                    " '" + txtUhid.Text + "'," +
                     " '" + txtName.Text + "'," +
                     " " + txtAge.Text + "," +
                     " '" + xGender + "'," +
                     " '" + rchAddress.Text + "', " +
                     "'" + txtMobileNo.Text + "')";
            }
            else
            {
                xQry = "update m_patient_registration set " +
                    " uhid = '" + txtUhid.Text + "', " +
                    " patient_name = '" + txtName.Text + "', " +
                    " patient_address = '" + rchAddress.Text + "', " +
                     "patient_mobileno = '" + txtMobileNo.Text + "'," +
                     "age = " + txtAge.Text + " " +
                    " where  patient_id= " + txtPatientId.Text + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show("Saved/Updated");
            LoadGrid();
            DataClear();

        }
        private void LoadGrid()
        {
            string xQry = "select patient_id,uhid,patient_name,patient_address,patient_mobileno,age,gender from m_patient_registration";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }
        private void DataClear()
        {
            txtName.Text = "";
            rchAddress.Text = "";
            txtAge.Text = "";
            txtPatientId.Text = "";
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
                txtPatientId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUhid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                rchAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMobileNo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnSave.Text = "UPDATE";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "patient_name Like '%" + txtSearch.Text + "%' OR uhid LIKE '%" + txtSearch.Text + "%' OR patient_mobileno LIKE '%" + txtSearch.Text + "%' OR patient_address LIKE '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }
    }
}
