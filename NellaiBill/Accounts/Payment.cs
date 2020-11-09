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
    public partial class Payment : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xPaymentId;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LoadGrid();
            xDb.LoadComboBox("select account_group_id,account_group_name from account_group order by account_group_name ", cmbGroup, "account_group_id", "account_group_name");
            txtReceiptNo.Text = xDb.GetMaxId("payment_id", "payment").ToString();
            cmbGroup.Select();

        }
        
        private void LoadGrid()
        {
            string xQuery = "select p.payment_id,p.date as Date," +
                " p.group_id,g.account_group_name as GroupName," +
                " p.amount as Amount,p.remarks as Remarks" +
                " from payment p, account_group g " +
                " where g.account_group_id= p.group_id";
            cmbGroup.SelectedIndex = 1;
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }


        private void DataClear()
        {
            txtAmount.Text = "";
            txtRemarks.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtReceiptNo.Text = xDb.GetMaxId("receipt_id", "receipt").ToString();

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xPaymentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtReceiptNo.Text = xPaymentId.ToString();
            dtpBillDate.Text = dataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString();
            cmbGroup.Text = dataGridView1.Rows[e.RowIndex].Cells["GroupName"].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
            txtRemarks.Text = dataGridView1.Rows[e.RowIndex].Cells["Remarks"].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
        }

        private void Payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSaveUpdate.PerformClick();
            }
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (Convert.ToInt32(cmbGroup.SelectedValue) == 0)
            {
                MessageBox.Show("Please Choose Group");
                cmbGroup.Focus();
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
                xQry = "insert into payment(date,group_id,amount,remarks,created_by,created_on) " +
                    " values('" + dtpBillDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    " '" + cmbGroup.SelectedValue + "' ," +
                    " '" + txtAmount.Text + "'," +
                    " '" + txtRemarks.Text + "'," +
                    " '" + xUser + "'," +
                    " '" + xCurrentDateTime + "' )";
            }
            else
            {
                xQry = "update payment " +
                    " set date='" + dtpBillDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                    " group_id = '" + cmbGroup.SelectedValue + "',  " +
                    " amount = '" + txtAmount.Text + "',  " +
                    " remarks = '" + txtRemarks.Text + "',  " +
                    " updated_by = '" + xUser + "',  " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  payment_id= " + xPaymentId + "";
            }
            xDb.DataProcess(xQry);
            LoadGrid();
            DataClear();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalClass globalClass = new GlobalClass();
            globalClass.AcceptOnlyNumeric(e);
        }
    }
}
