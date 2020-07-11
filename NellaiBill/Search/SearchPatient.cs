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

namespace NellaiBill.Master
{

    public partial class SearchPatient : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public int xPatientId { get; set; }
        public string xPatientName { get; set; }
        public string xPatientAddress { get; set; }
        public string xPatientMobileNo { get; set; }
        public string xUhid { get; set; }
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //refer key activities
            xPatientId = 0;
            txtSearch.Select();
            xDb.LoadGrid("select patient_id,uhid,patient_name as Name," +
                " patient_address as Address,patient_mobileno as MobileNo " +
                " from m_patient_registration", dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            ConfigResponseModel configResponseModel = xDb.GetConfig();
            if (configResponseModel.IsHms == "NO")
            {
                dataGridView1.Columns[1].Visible = false;
            }
            dataGridView1.Columns[2].FillWeight = 100;
            dataGridView1.Columns[3].FillWeight = 240;
            dataGridView1.Columns[4].FillWeight = 80;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xPatientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            xUhid = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            xPatientName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            xPatientAddress = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            xPatientMobileNo = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (xPatientName == "")
            {
                MessageBox.Show("Please select different PatientName");
                return;
            }
            this.Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                DataGridViewRow dgr = dataGridView1.CurrentRow;

                xPatientId = Convert.ToInt32(dgr.Cells[0].Value.ToString());
                xUhid = dgr.Cells[1].Value.ToString();
                xPatientName = dgr.Cells[2].Value.ToString();
                xPatientAddress = dgr.Cells[3].Value.ToString();
                xPatientMobileNo = dgr.Cells[4].Value.ToString();
                if (xPatientName == "")
                {
                    MessageBox.Show("Please select different PatientName");
                    return;
                }
                this.Close();
            }
        }

        private void SearchPatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "Name Like '%" + txtSearch.Text + 
                "%' OR uhid LIKE '%" + txtSearch.Text +
                "%' OR MobileNo LIKE '%" + txtSearch.Text +
                "%' OR Address LIKE '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }
    }
}
