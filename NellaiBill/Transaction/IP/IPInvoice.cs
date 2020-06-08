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
    public partial class IPInvoice : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public IPInvoice()
        {
            InitializeComponent();
        }

        private void IPInvoice_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBoxData("select ipno,admitted_by from ip_admission", cmbIPNo);
            xDb.LoadComboBox("select m_ip_fees_id,ip_fees_name from m_ip_fees", cmbParticulars, "m_ip_fees_id", "ip_fees_name");
            cmbParticulars.SelectedIndex = 1;
            dgvFinalSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinalSummary.Columns["Fees"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            txtInvoiceNo.Text = xDb.GetMaxId("ip_invoice_id", "ip_invoice").ToString();
            dgvFinalSummary.ReadOnly = true;
        }



        private void btnParticularsAdd_Click(object sender, EventArgs e)
        {
            if (txtParticularFees.Text == "")
            {
                MessageBox.Show("Enter Fees");
                txtParticularFees.Focus();
                return;
            }
            this.dgvFinalSummary.Rows.Add(cmbParticulars.Text, txtParticularFees.Text);
            CalculateTotalAmount();
            txtParticularFees.Text = "";
        }

        private void cmbIPNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataClear();
            IPDetailModel result = xDb.GetIpDetailsFromIpNo(Convert.ToInt32(cmbIPNo.Text));
            lblPatientName.Text = lblPatientName.Text + " : " + result.PatientName.ToString();
            lblTotalAdvancePaid.Text = xDb.GetAdvancePaymentFromIpNo(Convert.ToInt32(cmbIPNo.Text));
            txtAdvance.Text = xDb.GetAdvancePaymentFromIpNo(Convert.ToInt32(cmbIPNo.Text));     
            LoadAdvanceGrid();
        }
        private void DataClear()
        {
            lblPatientName.Text = "Name";
            lblTotalAdvancePaid.Text = "Advance Recieved";
        }

        private void LoadAdvanceGrid()
        {
            int xIpNo = Convert.ToInt32(cmbIPNo.Text.ToString());
            string xQry = "select date,amount from ip_advance_payment where ipno =" + xIpNo;
            xDb.LoadGrid(xQry, dataGridView1);
        }
        private void CalculateTotalAmount()
        {
            double xSubAmount = 0;
            double xTotalAmount = 0;
            foreach (DataGridViewRow dr in dgvFinalSummary.Rows)
            {
                xSubAmount += Convert.ToDouble(dr.Cells["Fees"].Value);
            }
            txtSubTotal.Text = xSubAmount.ToString();
            double xLessAmount = Convert.ToDouble(txtLessAmount.Text.ToString());
            double xAdvance = Convert.ToDouble(txtAdvance.Text.ToString());
            xTotalAmount = xSubAmount - xAdvance - xLessAmount;
            lblTotalAmont.Text = xTotalAmount.ToString();
        }

        private void dgvFinalSummary_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalculateTotalAmount();
        }
    }
}
