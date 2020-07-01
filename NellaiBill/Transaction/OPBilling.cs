using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
    public partial class OPBilling : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public OPBilling()
        {
            InitializeComponent();
        }

        private void btnDoctorSearch_Click(object sender, EventArgs e)
        {

            SearchDoctor search = new SearchDoctor();
            search.ShowDialog();
            if (search.xDoctorId.ToString() != "0")
            {
                txtDoctorName.Text = search.xDoctorName.ToString();
                txtDoctorId.Text = search.xDoctorId.ToString();
            }
            GetMaxTokenNo();
            cmbCaseType.Select();
        }

        private void OutPatientEntry_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtOpId.Text = xDb.GetMaxId("txno", "outpatientdetails").ToString();
            cmbCaseType.Select();
            LoadGrid();
        }

        private void OutPatientEntry_KeyDown(object sender, KeyEventArgs e)
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

        private void GetMaxTokenNo()
        {
            txtTokenNo.Text = "";
            string xQry = "SELECT  CASE WHEN max(tokenno)IS NULL OR max(tokenno)= '' THEN '1' ELSE " +
              " max(tokenno)+1 END AS tokenno FROM outpatientdetails " +
              " WHERE doctor_id = '" + txtDoctorId.Text + "' " +
              " and date = '" + dtpOpEntryDate.Value.ToString("yyyy-MM-dd") + "' " +
              " and noontype = '" + cmbNoonType.SelectedItem + "'" +
              " and casetype = '" + cmbCaseType.SelectedItem + "'";
            txtTokenNo.Text = xDb.GetTokenNoForOP(xQry);
        }


        private void DataClear()
        {
            GetMaxTokenNo();
            txtPatientId.Text = "";
            txtPatientName.Text = "";
            rchPatientAddress.Text = "";
            txtDoctorId.Text = "";
            txtDoctorName.Text = "";
            txtTokenNo.Text = "";
            txtOpId.Text = xDb.GetMaxId("txno", "outpatientdetails").ToString();
            cmbCaseType.Select();
            btnSaveUpdate.Text = "SAVE";
        }
        private void LoadGrid()
        {
            //string xQry = "select doctor_id as DoctorId,doctor_name as DoctorName," +
            //    " gender as Gender,address as Address,mobileno as MobileNo,created_by as CreatedBy from m_doctor";
            string xQry = "select o.txno as TxNo,o.tokenno as Token,o.date as Date," +
                " o.noontype as Noon,o.uhid as UHID,p.patient_name as Name," +
                " o.casetype as CaseType,o.casetype1 as CaseType1,o.doctor_id,d.doctor_name as Doctor ," +
                " o.fees as Fees ,o.payment_status as Payment,op_status as Status " +
                " from  outpatientdetails o, m_patient_registration p, m_doctor d " +
                " where p.patient_id = o.patient_id " +
                " and d.doctor_id = o.doctor_id " +
                " and  o.date ='" + Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd") + "'";
            xDb.LoadGrid(xQry, dataGridView1); 
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns["Name"].Width = 200;
            dataGridView1.Columns["Doctor"].Width = 150;
            dataGridView1.Columns["Fees"].Width = 50;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void cmbCaseType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetMaxTokenNo();
        }

        private void cmbNoonType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetMaxTokenNo();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            OPPrint(Convert.ToInt32(txtOpId.Text));
        }
        private void OPPrint(int OPNo)
        {

            DialogResult result = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                ReportDocument reportDocument = new ReportDocument();
                GlobalClass globalClass = new GlobalClass();
                string path = globalClass.GetReportPath() + "rptOutpatientBill.rpt";
                reportDocument.Load(path);
                reportDocument.SetParameterValue("opno", OPNo);
                reportDocument.PrintToPrinter(1, true, 0, 0);
            }
            else if (result == DialogResult.No)
            {
                //...
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                txtOpId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPatientName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtUhid.Text = dataGridView1.Rows[e.RowIndex].Cells["UHID"].Value.ToString();
                cmbCaseType1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDoctorId.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtDoctorName.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtFees.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                cmbPaymentStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                cmbOpPatientStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                btnSaveUpdate.Text = "UPDATE";

            }
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass globalClass = new GlobalClass();
            globalClass.AcceptOnlyNumeric(e);
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {

            if (cmbCaseType1.Text == "")
            {
                MessageBox.Show("Something Wrong!!! CaseType1");
                cmbCaseType1.Select();
                return;
            }
            if (txtFees.Text == "")
            {
                MessageBox.Show("Enter Fees");
                txtFees.Focus();
                return;
            }
            if (cmbPaymentStatus.Text == "")
            {
                MessageBox.Show("Something Wrong!!! PaymentStatus");
                cmbPaymentStatus.Select();
                return;
            }

            if (cmbOpPatientStatus.Text == "")
            {
                MessageBox.Show("Something Wrong!!! OpPatientStatus");
                cmbOpPatientStatus.Select();
                return;
            }



            string xQry = "";

            if (btnSaveUpdate.Text == "SAVE")
            {
                if (txtOpId.Text == "")
                {
                    MessageBox.Show("Something Wrong!!! Op Id");
                    return;
                }
                if (txtPatientId.Text == "")
                {
                    MessageBox.Show("Something Wrong!!! Patient Details");
                    return;
                }
                if (txtDoctorId.Text == "")
                {
                    MessageBox.Show("Something Wrong!!! Doctor Details");
                    return;
                }
                if (cmbCaseType.Text == "")
                {
                    MessageBox.Show("Something Wrong!!! CaseType");
                    cmbCaseType.Select();
                    return;
                }
                if (cmbNoonType.Text == "")
                {
                    MessageBox.Show("Something Wrong!!! NoonType");
                    cmbNoonType.Select();
                    return;
                }
                if (txtTokenNo.Text == "")
                {
                    MessageBox.Show("Something Wrong!!! Token No");
                    return;
                }

                xQry = "insert into outpatientdetails" +
                    " values ( " + txtOpId.Text + ",'" + txtTokenNo.Text + "','" + dtpOpEntryDate.Value.ToString("yyyy-MM-dd") + "', " +
                    " '" + cmbNoonType.SelectedItem.ToString() + "', " +
                    " " + txtPatientId.Text + ", " +
                    " '" + txtUhid.Text + "', " +
                    " '" + cmbCaseType.SelectedItem.ToString() + "'," +
                    " '" + cmbCaseType1.SelectedItem.ToString() + "'," +
                    " " + txtDoctorId.Text + "," +
                    " " + txtFees.Text + "," +
                    " '" + cmbPaymentStatus.SelectedItem.ToString() + "'," +
                    " '" + cmbOpPatientStatus.SelectedItem.ToString() + "'," +
                    " '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    " '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "' )";

                xDb.DataProcess(xQry);
                if (cmbCaseType1.Text == "Injection" || cmbCaseType1.Text == "Anc" || cmbCaseType1.Text == "GreenFile")
                {

                }
                else
                {
                    OPPrint(Convert.ToInt32(txtOpId.Text));
                }
            }
            else
            {
                xQry = "update outpatientdetails set " +
                    " casetype1 = '" + cmbCaseType1.SelectedItem.ToString() + "', " +
                    " fees = " + txtFees.Text + ", " +
                    " payment_status = '" + cmbPaymentStatus.SelectedItem.ToString() + "', " +
                    " updatedason = '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    " op_status = '" + cmbOpPatientStatus.SelectedItem.ToString() + "' " +
                    " where  txno= " + txtOpId.Text + "";
                xDb.DataProcess(xQry);
            }
            MessageBox.Show("Saved/Updated");


            LoadGrid();
            DataClear();
        }
    }
}
