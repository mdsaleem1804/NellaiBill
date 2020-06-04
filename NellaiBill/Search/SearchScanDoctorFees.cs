using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Search
{
    public partial class SearchScanDoctorFees : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public int xDoctorId { get; set; }
        public string xDoctorName { get; set; }
        public int xTestId { get; set; }
        public string xTestName { get; set; }
        public double xFees { get; set; }
        public SearchScanDoctorFees()
        {
            InitializeComponent();
        }

        private void SearchScanDoctorFees_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //refer key activities
            xDoctorId = 0;
            txtSearch.Select();
            xDb.LoadGrid("select d.doctor_id,d.doctor_name,f.scan_test_id,t.test_name,f.fees from m_doctor d, " +
                " m_scan_test_fees f, m_scan_test t where f.doctor_id = d.doctor_id " +
                " and f.scan_test_id = t.scan_test_id ", dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].FillWeight = 100;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].FillWeight = 100;
            dataGridView1.Columns[4].FillWeight = 60;
        }

        private void SearchScanDoctorFees_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "doctor_name Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void SearchScanDoctorFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xDoctorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            xDoctorName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            xTestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            xTestName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            xFees = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            if (xDoctorName == "")
            {
                MessageBox.Show("Please select different DoctorName");
                return;
            }
            this.Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                DataGridViewRow dgr = dataGridView1.CurrentRow;
                xDoctorId = Convert.ToInt32(dgr.Cells[0].Value.ToString());
                xDoctorName = dgr.Cells[1].Value.ToString();
                xTestId = Convert.ToInt32(dgr.Cells[2].Value.ToString());
                xTestName = dgr.Cells[3].Value.ToString();
                xFees = Convert.ToInt32(dgr.Cells[4].Value.ToString());
                if (xDoctorName == "")
                {
                    MessageBox.Show("Please select different DoctorName");
                    return;
                }
               
                this.Close();
            }
        }
    }
}
