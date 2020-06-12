using MySql.Data.MySqlClient;
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
    public partial class IPInvoice : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public IPInvoice()
        {
            InitializeComponent();
        }

        private void IPInvoice_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBoxData("select ipno,admitted_by from ip_admission where is_discharged=0", cmbIPNo);
            xDb.LoadComboBox("select ip_fees_id,ip_fees_name from m_ip_fees", cmbParticulars, "ip_fees_id", "ip_fees_name");
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
            lblPatientName.Text =  result.PatientName.ToString();
            lblAddress.Text = result.PatientAddress.ToString();
            txtAdvance.Text = xDb.GetAdvancePaymentFromIpNo(Convert.ToInt32(cmbIPNo.Text));     
            LoadAdvanceGrid();
        }
        private void DataClear()
        {
            lblPatientName.Text = "Name";
            lblAddress.Text = "Address";
            txtAdvance.Text = xDb.GetAdvancePaymentFromIpNo(Convert.ToInt32(cmbIPNo.Text));
            txtSubTotal.Text = "";
            txtParticularFees.Text = "";
        }

        private void LoadAdvanceGrid()
        {
            int xIpNo = Convert.ToInt32(cmbIPNo.Text.ToString());
            string xQry = "select date,amount from ip_advance_payment where ipno =" + xIpNo;
            xDb.LoadGrid(xQry, dgvAdvanceSummary);
        }
        private void CalculateTotalAmount()
        {
            double xSubAmount = 0;
            double xTotalAmount = 0;
            double xLessAmount = 0;
            foreach (DataGridViewRow dr in dgvFinalSummary.Rows)
            {
                xSubAmount += Convert.ToDouble(dr.Cells["Fees"].Value);
            }
            txtSubTotal.Text = xSubAmount.ToString();
            if (txtLessAmount.Text == "") 
            {
                xLessAmount = 0;
            }
            else
            {
                 xLessAmount = Convert.ToDouble(txtLessAmount.Text.ToString());
            }

            double xAdvance = Convert.ToDouble(txtAdvance.Text.ToString());
            xTotalAmount = xSubAmount - xAdvance - xLessAmount;
            lblTotalAmont.Text = xTotalAmount.ToString();
        }

        private void dgvFinalSummary_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            CalculateTotalAmount();
        }

        private void txtLessAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Total Amount " + lblTotalAmont.Text.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SaveData();
            }
            else if (result == DialogResult.No)
            {
                //...
            }
        }
        private void SaveData()
        {
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                int xTxno = 1;
                try
                {
                    foreach (DataGridViewRow dr in dgvFinalSummary.Rows)
                    {  
                        int xAmount = Convert.ToInt32(dr.Cells["Fees"].Value);
                     
                        string xQryIpInvoiceDetails = "insert into   ip_invoice_details" +
                           "(ip_invoice_id,txno,particulars,amount) " +
                           "values(" + txtInvoiceNo.Text+ "," +
                           " " + xTxno + "," +
                           " '" + dr.Cells["Particulars"].Value + "'," +
                           " " + xAmount + ")";
                        xTxno += 1;
                        myCommand.CommandText = xQryIpInvoiceDetails;
                        myCommand.ExecuteNonQuery(); 
                    }

                    string xQryIpInvoice = "insert into   ip_invoice" +
                          "(ip_invoice_id,date,ipno,sub_amount,advance_amount,less_amount,total_amount,created_by,created_on) " +
                          "values(" + txtInvoiceNo.Text + "," +
                          " '" + dtpBillDate.Value.ToString("yyyy-MM-dd") + "'," +
                          " '" + Convert.ToInt32(cmbIPNo.Text) + "'," +
                          " '" + Convert.ToDouble(txtSubTotal.Text) + "'," +
                          " '" + Convert.ToDouble(txtAdvance.Text) + "'," +
                          " '" + Convert.ToDouble(txtLessAmount.Text) + "'," +
                          " '" + Convert.ToDouble(lblTotalAmont.Text) + "'," +
                          " '" + LoginInfo.UserID+ "'," +
                          " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                    
                    myCommand.CommandText = xQryIpInvoice;
                    myCommand.ExecuteNonQuery();

                    string xQryUpdateAdmission = "update ip_admission set is_discharged=1 where ipno=" + txtInvoiceNo.Text;
                    myCommand.CommandText = xQryUpdateAdmission;

                    myCommand.ExecuteNonQuery();
                    myTrans.Commit();
                    MessageBox.Show("Record Saved Succesfully Id is " + txtInvoiceNo.Text);
                    DataClear();
                    txtLessAmount.Text = "";
                    txtSubTotal.Text = "0";
                    lblTotalAmont.Text = "0";
                    cmbIPNo.SelectedIndex = 0;
                    txtAdvance.Text = "0";
                    dgvAdvanceSummary.DataSource = null;
                    dgvFinalSummary.Rows.Clear();
                    xDb.LoadComboBoxData("select ipno,admitted_by from ip_admission where is_discharged=0", cmbIPNo);
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
    }
}
