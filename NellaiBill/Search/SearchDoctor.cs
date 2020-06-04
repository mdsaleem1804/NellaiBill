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
    public partial class SearchDoctor : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public int xDoctorId { get; set; }
        public string xDoctorName { get; set; }
        public SearchDoctor()
        {
            InitializeComponent();
        }

        private void SearchDoctor_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //refer key activities
            xDoctorId = 0;
            txtSearch.Select();
            xDb.LoadGrid("select doctor_id,doctor_name,address,mobileno from m_doctor", dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].FillWeight = 200;
            dataGridView1.Columns[2].FillWeight = 60;
            dataGridView1.Columns[3].FillWeight = 60;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "doctor_name Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xDoctorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            xDoctorName =dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                if (xDoctorName == "")
                {
                    MessageBox.Show("Please select different DoctorName");
                    return;
                }
                this.Close();
            }
        }

        private void SearchDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
