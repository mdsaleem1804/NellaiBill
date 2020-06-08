using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using NellaiBill.Common;
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

namespace NellaiBill.Transaction.IP
{
    public partial class IPAdmission : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public IPAdmission()
        {
            InitializeComponent();
        }

        private void IPAdmission_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select doctor_id,doctor_name from m_doctor", cmbDoctor, "doctor_id", "doctor_name");
            xDb.LoadComboBox("select room_id,room_name from m_room", cmbRoom, "room_id", "room_name");
            xDb.LoadComboBox("select case_type_id,case_type_name from m_case_type", cmbCaseType, "case_type_id", "case_type_name");
            txtIpNo.Text = xDb.GetMaxId("ipno", "ip_admission").ToString();
            this.KeyPreview = true;
            LoadGrid();
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int xRoomId = Convert.ToInt32(cmbRoom.SelectedValue.ToString());
            GetRoomFees(xRoomId);
        }
        private void GetRoomFees(int roomid)
        {
            txtRoomFees.Text = xDb.GetRoomFees(roomid);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string xQry = "";
            int xDoctorId = Convert.ToInt32(cmbDoctor.SelectedValue.ToString());
            int xRoomId = Convert.ToInt32(cmbRoom.SelectedValue.ToString());
            int xCaseTypeId = Convert.ToInt32(cmbCaseType.SelectedValue.ToString());
            double xAmount = Convert.ToDouble(txtRoomFees.Text.ToString());
            int xIpNo = Convert.ToInt32(txtIpNo.Text.ToString());
            if (xDoctorId == 0)
            {
                MessageBox.Show("Please Choose Doctor");
                cmbDoctor.Select();
                return;
            }
            if (xCaseTypeId == 0)
            {
                MessageBox.Show("Please Choose CaseType");
                cmbCaseType.Select();
                return;
            }
            if (xRoomId == 0)
            {
                MessageBox.Show("Please Choose Room");
                cmbRoom.Select();
                return;
            }


            if (btnSaveUpdate.Text == "SAVE")
            {


                xQry = "insert into ip_admission (ipno,date,patient_id,doctor_id,case_type_id,room_id,admitted_by,created_by,created_on)" +
                     " values ( " + xIpNo + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," +
                     " " + txtPatientId.Text + ", " +
                     " '" + xDoctorId + "', " +
                     " '" + xCaseTypeId + "'," +
                     " '" + xRoomId + "'," +
                     " '" + txtAdmittedBy.Text + "'," +
                     " '" + LoginInfo.UserID + "'," +
                     " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' )";

                xDb.DataProcess(xQry);
                DialogResult result = MessageBox.Show("Do you want to print?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                   // PrintBill(xIpNo);
                }
                else if (result == DialogResult.No)
                {
                    //...
                }


            }
            else
            {
                xQry = "update ip_admission set " +
                    " patient_id = '" + txtPatientId.Text + "', " +
                    " doctor_id = " + xDoctorId + ", " +
                    " case_type_id = '" + xCaseTypeId + "', " +
                    " room_id = '" + xRoomId + "', " +
                    " admitted_by = '" + txtAdmittedBy.Text + "', " +
                    " updated_by = '" + LoginInfo.UserID + "', " +
                    " updated_on = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' " +
                    " where  ipno= " + xIpNo + "";
                xDb.DataProcess(xQry);
            }
            MessageBox.Show("Saved/Updated");
            LoadGrid();
            DataClear();
        }
        private void DataClear()
        {
            txtIpNo.Text = xDb.GetMaxId("ipno", "ip_admission").ToString();
            txtAdmittedBy.Text = "";
            txtPatientId.Text = "";
            txtPatientName.Text = "";
            txtRoomFees.Text = "";

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
        private void LoadGrid()
        {
      
            string xQry = "select ip.ipno,ip.date,ip.patient_id,p.patient_name,p.patient_address,  " +
                " ip.doctor_id,d.doctor_name, " +
                " ip.case_type_id,ct.case_type_name, " +
                " ip.room_id,r.room_name, " +
                " ip.admitted_by " +
                " from  ip_admission ip, " +
                " m_patient_registration p,  " +
                " m_doctor d ,m_case_type ct ,m_room r  " +
                " where p.patient_id = ip.patient_id " +
                " and d.doctor_id = ip.doctor_id  " +
                " and ct.case_type_id=ip.case_type_id " +
                " and r.room_id = ip.room_id " +
                " and  ip.date ='" + Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd") + "'";

            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }
        private void IPAdmission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F)
            {
                cmbDoctor.Focus();
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
            }
            cmbDoctor.Select();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIpNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpBillDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPatientId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPatientName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                rchPatientAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbDoctor.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbCaseType.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                cmbRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtAdmittedBy.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                btnSaveUpdate.Text = "UPDATE";
            }
        }
    }
}
