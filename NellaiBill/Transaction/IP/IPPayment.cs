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
    public partial class IPPayment : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public IPPayment()
        {
            InitializeComponent();
        }

        private void IPPayment_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBoxData("select ipno,admitted_by from ip_admission where is_paid=0", cmbIPNo);
            txtAdvanceBillNo.Text = xDb.GetMaxId("advance_payment_id", "ip_advance_payment").ToString();
            this.KeyPreview = true;
            if (cmbIPNo.Items.Count > 0)
                cmbIPNo.SelectedIndex = 0;
            else
                MessageBox.Show("IP - Patient Not Exists");
            LoadGrid();
        }
        private void LoadGrid()
        {

            string xQry = "select ip.ipno,ip.date,ip.patient_id,p.patient_name,p.patient_address,  " +
                " ip.case_type_id,ct.case_type_name, " +
                " ip.room_id,r.room_name, " +
                " ip.admitted_by,adv.amount " +
                " from  ip_advance_payment adv, " +
                " m_patient_registration p,  " +
                " ip_admission ip ,m_case_type ct ,m_room r  " +
                " where p.patient_id = ip.patient_id " +
                " and adv.ipno = ip.ipno  " +
                " and ct.case_type_id=ip.case_type_id " +
                " and r.room_id = ip.room_id ";

            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Enter Amount");
                txtAmount.Focus();
                return;
            }

            string xQry = "";
            if (btnSave.Text == "SAVE")
            {
                xQry = "insert into  ip_advance_payment(date,ipno,amount) " +
                    " values('" + dtpBillDate.Value.ToString("yyyy-MM-dd") + "', " +
                    " " + cmbIPNo.Text + " , " +
                    " " + txtAmount.Text + " )";
            }         
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
            cmbIPNo.SelectedIndex = 0;
            DialogResult result = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //PrintBill(xEcgBillId);
            }
            else if (result == DialogResult.No)
            {
                //...
            }
        }

        private void cmbIPNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClear();
            IPDetailModel result =xDb.GetIpDetailsFromIpNo(Convert.ToInt32(cmbIPNo.Text));
           lblPatientId.Text = lblPatientId.Text + " : " + result.PatientId.ToString();
            lblPatientName.Text = lblPatientName.Text + " : " + result.PatientName.ToString();
            //lblPatientAddress.Text = lblPatientAddress.Text + " : " + result.PatientAddress.ToString();
            lblTotalAdvancePaid.Text = xDb.GetAdvancePaymentFromIpNo(Convert.ToInt32(cmbIPNo.Text));
            lblRoomId.Text = lblRoomId.Text + " : " + result.RoomId.ToString();
        }
        private void DataClear()
        {
            txtAdvanceBillNo.Text = xDb.GetMaxId("advance_payment_id", "ip_advance_payment").ToString();
            txtAmount.Text = "";
            lblPatientId.Text = "Patient Id";
            lblPatientName.Text = "Name ";
            //lblPatientAddress.Text = "Address ";
            lblTotalAdvancePaid.Text = "Total Advance Paid ";
            lblRoomId.Text = "Room No";
        }
    }
    
}
