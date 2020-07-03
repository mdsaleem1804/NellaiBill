using NellaiBill.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Accounts
{

    public partial class Receipt : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xReceiptId;
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LoadGrid();
            xDb.LoadComboBox("select patient_id,patient_name from m_patient_registration order by patient_name ", cmbLedger, "patient_id", "patient_name");
            txtReceiptNo.Text = xDb.GetMaxId("receipt_id", "receipt").ToString();
            cmbLedger.Select();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (Convert.ToInt32(cmbLedger.SelectedValue) == 0)
            {
                MessageBox.Show("Please Choose Ledger");
                cmbLedger.Focus();
                return;
            }
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Enter Amount");
                txtAmount.Focus();
                return;
            }
          
            string xQry = "";

            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into receipt(date,customer_id,amount,remarks,created_by,created_on) " +
                    " values('" + dtpBillDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    " '" + cmbLedger.SelectedValue + "' ," +
                    " '" + txtAmount.Text + "'," +
                    " '" + txtRemarks.Text + "'," +
                    " '" + xUser + "'," +
                    " '" + xCurrentDateTime + "' )";
            }
            else
            {
                xQry = "update receipt " +
                    " set date='" + dtpBillDate.Value.ToString("yyyy-MM-dd HH:mm:ss")+ "', " +
                    " customer_id = '" + cmbLedger.SelectedValue + "',  " +
                    " amount = '" + txtAmount.Text + "',  " +
                    " remarks = '" + txtRemarks.Text + "',  " +
                    " updated_by = '" + xUser + "',  " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  receipt_id= " + xReceiptId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }
        private void LoadGrid()
        {
            string xQuery = "select r.receipt_id,r.date,p.patient_name,r.amount,r.remarks from receipt r , m_patient_registration p where p.patient_id = r.customer_id";
            cmbLedger.SelectedIndex = 1;
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }


        private void DataClear()
        {
            txtAmount.Text = "";
            txtRemarks.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtReceiptNo.Text = xDb.GetMaxId("receipt_id", "receipt").ToString();

        }

        private void Receipt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSaveUpdate.PerformClick();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xReceiptId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtReceiptNo.Text = xReceiptId.ToString();
            dtpBillDate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbLedger.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRemarks.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass globalClass = new GlobalClass();
            globalClass.AcceptOnlyNumeric(e);
        }
    }
}
