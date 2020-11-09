using MySql.Data.MySqlClient;
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
    public partial class LabBilling : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public LabBilling()
        {
            InitializeComponent();
        }

        private void LabEntry_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            txtLabId.Text = xDb.GetMaxId("lab_id", "billing_lab").ToString();
            xDb.LoadComboBox("select doctor_id,doctor_name from m_doctor", cmbDoctor, "doctor_id", "doctor_name");
            cmbDoctor.SelectedIndex = 0;
            LoadGrid();
        }
        private void LoadGrid()
        {
            string xQry = "select lab_test_fees_id,test_name as TestName, amount as Amount from  m_lab_test_fees";
            xDb.LoadGrid(xQry, dataGridView1);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Width = 100;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                foreach (DataGridViewRow dr in dataGridView2.Rows)
                {

                    string xDataGridTestItem = dr.Cells[1].Value.ToString();
                    if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == xDataGridTestItem)
                    {
                        MessageBox.Show("Test entered already.");
                        return;
                    }
                }

                this.dataGridView2.Rows.Add(
                dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                CalculateTotalAmount();
            }
            dataGridView2.Columns[0].Visible = false;

        }
        private void CalculateTotalAmount()
        {
            double xAmount = 0;
            double xTotalAmount = 0;

            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                xAmount += Convert.ToDouble(dr.Cells["Amount"].Value);
            }

            xTotalAmount = xAmount;
            lbl_total_amount_value.Text = xTotalAmount.ToString();
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

        private void LabBilling_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F)
            {
                txtSearch.Focus();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "TestName Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);

        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            int xDoctorId = Convert.ToInt32(cmbDoctor.SelectedValue.ToString());

            if (txtLabId.Text == "")
            {
                MessageBox.Show("Something Wrong - Lab Id !!!");
                return;
            }
            if (txtPatientId.Text == "")
            {
                MessageBox.Show("Please Fill Patient");
                btnPatientSearch.Select();
                return;
            }
            if (xDoctorId == 0)
            {
                MessageBox.Show("Please Fill Doctor");
                cmbDoctor.Select();
                return;
            }
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Add some test before billing !!!");
                txtSearch.Focus();
                return;
            }
            int xLabId = Convert.ToInt32(txtLabId.Text);
            using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
            {
                myConnection.Open();
                MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                MySqlCommand myCommand = myConnection.CreateCommand();
                try
                {
                    foreach (DataGridViewRow dr in dataGridView2.Rows)
                    {
                        int xTestId = Convert.ToInt32(dr.Cells[0].Value);
                        double xAmount = Convert.ToDouble(dr.Cells[2].Value);
                        int xTxNo =dr.Index+1;
                        string xQryLabBillDetails = "insert into   billing_lab_details" +
                           "(lab_id,txno,test_id,amount)" +
                           "values(" + xLabId + "," +
                           " " + xTxNo + "," +
                           " " + xTestId + "," +
                           " " + xAmount + ")";

                        myCommand.CommandText = xQryLabBillDetails;
                        myCommand.ExecuteNonQuery();
                    }

                    string xQryLabBill = "insert into   billing_lab" +
                          "(lab_id,date,patient_id,doctor_id,total_amount,created_by,created_on) " +
                          "values(" + xLabId + "," +
                          " '" + dtpBillDate.Value.ToString("yyyy-MM-dd") + "'," +
                          " " + Convert.ToInt32(txtPatientId.Text.ToString()) + "," +
                          " " + Convert.ToInt32(cmbDoctor.SelectedValue.ToString()) + "," +
                          " '" + Convert.ToDouble(lbl_total_amount_value.Text) + "'," +
                          " '" + "TEST" + "'," +
                          " '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' )";

                    myCommand.CommandText = xQryLabBill;
                    myCommand.ExecuteNonQuery();

                    myTrans.Commit();
                    MessageBox.Show("Record Saved Succesfully Id is " + xLabId);
                    DataClear();
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
        private void DataClear()
        {
            txtPatientId.Text = "";
            txtPatientName.Text = "";
            rchPatientAddress.Text = "";
            txtUhid.Text = "";
            txtSearch.Text = "";
            dataGridView2.Rows.Clear();
            txtLabId.Text = xDb.GetMaxId("lab_id", "billing_lab").ToString();           
            cmbDoctor.SelectedIndex = 0;
        }
    }
}
