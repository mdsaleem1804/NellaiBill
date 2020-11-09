using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Reports
{
    public partial class SalesReportDG : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public SalesReportDG()
        {
            InitializeComponent();
        }

        private void SalesReportDG_Load(object sender, EventArgs e)
        {

            LoadComboBox();
            cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbItem.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbLedger.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLedger.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadComboBox()
        {
            xDb.LoadComboBox("select i.product_id,i.product_name from m_product i", cmbItem, "product_id", "product_name");
            xDb.LoadComboBox("SELECT account_ledger_id, ledger_name FROM account_ledger  where ledger_undergroup_no = 5 order by ledger_name", cmbLedger, "account_ledger_id", "ledger_name");
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            string xFilter = "";
            if (mChkSelectAllItem.Checked)
            {

            }
            else
            {
                string xItemNo = cmbItem.SelectedValue.ToString();
                xFilter += " and s.product_id=" + xItemNo ;
            }
            if (mChkSelectAllCustomer.Checked)
            {

            }
            else
            {
                string xLedgerId = cmbLedger.SelectedValue.ToString();
                xFilter += " and s.customerno=" + xLedgerId;
            }
            if (txtInvoiceNo.Text.Length>0)
            {
                xFilter += " and s.sales_id= " + txtInvoiceNo.Text.ToString();
            }
            string xQuery = "select s.sales_id as INVNO,a.ledger_name as CUSTOMER,s.date as DATE,i.product_name as product_name,s.batchid as BATCH,s.qty as QTY" +
                " from sales_details s,  account_ledger a,m_product i " +
                " where s.customerno = a.account_ledger_id and s.product_id = i.product_id " +
                " and date>='" + dtpFromDate.Text + "' and date <= '" + dtpToDate.Text + "' " + xFilter + " order by s.sales_id desc ";
            xDb.LoadGrid(xQuery, dataGridView1);
            dataGridView1.Columns["product_name"].Width = 200;
            dataGridView1.Columns["CUSTOMER"].Width = 200;         
            dataGridView1.Columns["INVNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["DATE"].DefaultCellStyle.Format = "dd /MMMM/yyyy";
            dataGridView1.Columns["qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
    }
}
