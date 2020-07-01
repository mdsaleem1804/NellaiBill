using System;
using System.Windows.Forms;

namespace NellaiBill.Master
{
    public partial class DoctorRegistration : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xDoctorId;
        GlobalClass globalClass = new GlobalClass();
        public DoctorRegistration()
        {
            InitializeComponent();
        }

        private void DoctorRegistration_Load(object sender, EventArgs e)
        {
            mBtnCancel.Visible = false;
            mBtnDelete.Visible = false;
            LoadGrid();
        }



        private void LoadGrid()
        {
            string xQry = "select doctor_id as DoctorId,doctor_name as DoctorName," +
                " address as Address,mobileno as MobileNo from m_doctor";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }
        private void DataClear()
        {
            txtName.Text = "";
            txtMobileNo.Text = "";
            rchAddress.Text = "";
            btnSaveUpdate.Text = "SAVE";
        }

     

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            xDoctorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rchAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMobileNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
            mBtnDelete.Enabled = true;
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            globalClass.AcceptOnlyNumeric(e);
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string xQry = "";
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Choose Name");
                txtName.Focus();
                return;
            }
            if (btnSaveUpdate.Text == "SAVE")
            {

                xQry = "insert into m_doctor (doctor_name,address,mobileno) " +
                    " values ( '" + txtName.Text + "','" + rchAddress.Text + "','" + txtMobileNo.Text + "')";
            }
            else
            {
                xQry = "update m_doctor set " +
                    " doctor_name = '" + txtName.Text + "', " +
                    " address = '" + rchAddress.Text + "', " +
                    " mobileno = '" + txtMobileNo.Text + "' " +
                    " where  doctor_id= " + xDoctorId + "";
            }
            xDb.DataProcess(xQry);
            MessageBox.Show("Saved/Updated");
            LoadGrid();
            DataClear();
        }
    }
}
