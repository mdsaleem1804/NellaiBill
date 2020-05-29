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
    public partial class OutPatientEntry : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public OutPatientEntry()
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
            cmbCaseType.SelectedText = "None";
            cmbNoonType.SelectedText = "Morning";
            cmbCaseType1.SelectedText = "General";
            cmbPaymentStatus.SelectedText = "Paid";
            cmbOpPatientStatus.SelectedText = "Processing";
            txtOpId.Text = xDb.GetMaxId("txno", "outpatientdetails").ToString();
            mBtnDelete.Visible = false;
            mBtnCancel.Visible = false;
           // mBtnSaveUpdate.Enabled = false;

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
        }

        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            SearchPatient search = new SearchPatient();
            search.ShowDialog();
            if (search.xPatientId.ToString() != "0")
            {
                
                txtPatientId.Text = search.xPatientId.ToString();
                txtPatientName.Text = search.xPatientName.ToString();
                rchPatientAddress.Text = search.xPatientAddress.ToString();

            }

        }

        private void cmbOpPatientStatus_Leave(object sender, EventArgs e)
        {
            GetMaxTokenNo();

        }
        private void GetMaxTokenNo()
        {
            txtTokenNo.Text = "";
            string xQry = "SELECT  CASE WHEN max(tokenno)IS NULL OR max(tokenno)= '' THEN '1' ELSE " +
              " max(tokenno)+1 END AS tokenno FROM outpatientdetails " +
              " WHERE doctorname = '" + txtDoctorName.Text + "' " +
              " and date = '" + dtpOpEntryDate.Value + "' " +
              " and noontype = '" + cmbNoonType.SelectedItem + "'" +
              " and casetype = '" + cmbCaseType.SelectedItem + "'";         
            txtTokenNo.Text = xDb.GetTokenNoForOP(xQry);
        }

        private void mBtnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (txtOpId.Text == "" )
            {
                MessageBox.Show("Something Wrong!!! Op Id");
                return;
            }
            if ( txtTokenNo.Text == "")
            {
                MessageBox.Show("Something Wrong!!! Token No");
                return;
            }
            if (txtFees.Text == "")
            {
                MessageBox.Show("Enter Fees");
                txtFees.Focus();
                return;
            }
        }
    }
}
