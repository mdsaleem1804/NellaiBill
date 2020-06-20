using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Reports
{
    public partial class StockReportDG : Form
    {

        DatabaseConnection xDb = new DatabaseConnection();
        public StockReportDG()
        {
            InitializeComponent();
            xDb.LoadComboBox("select i.product_id,i.product_name from m_product i", cmbItem, "product_id", "product_name");

        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            string xStockType=cmbStockType.Text.ToString();
            string xQry = "";
            if(xStockType== "Available Stock")
            {
                xQry = "and s.qty>0";
            }
           else if (xStockType == "Zero Stock")
            {
                xQry = "and s.qty=0";
            }
            else if (xStockType == "Negative Stock")
            {
                xQry = "and s.qty<0";
            }
            else if (xStockType == "All Stock")
            {
                xQry = "";
            }
            dataGridView1.ReadOnly = true;
            //dataGridView1.Columns[0].Width = 200;
            string xQuery = "SELECT i.product_name, s.qty, s.mrp, s.batch_id,s.expiry_date FROM stock s, m_product i WHERE i.product_id = s.product_id " + xQry;

            xDb.LoadGrid(xQuery, dataGridView1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "product_name Like '%" + txtSearch.Text +  "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbItem.AutoCompleteSource = AutoCompleteSource.ListItems;
            string xFilter = "";
            if (mChkSelectAllItem.Checked)
            {

            }
            else
            {
                string xItemNo = cmbItem.SelectedValue.ToString();
                xFilter += " and sh.product_id=" + xItemNo;
            }
            dataGridView2.ReadOnly = true;
            //DateTime xFromDate = DateTime.ParseExact(dtpFromDate.Text, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            //DateTime xToDate = DateTime.ParseExact(dtpToDate.Text, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string xQuery = "select p.product_id,p.product_name,sh.old_qty,sh.change_qty,sh.current_qty,sh.mrp,sh.batch_id,sh.expiry_date,sh.reason, sh.created_by,sh.created_on from stock_history sh, m_product p where sh.product_id = p.product_id " +
                " and sh.created_on>='" + Convert.ToDateTime(dtpFromDate.Text).ToString("yyyy-MM-dd HH:mm:ss") + "' and sh. created_on <= '" + Convert.ToDateTime(dtpToDate.Text).ToString("yyyy-MM-dd HH:mm:ss") + "' " + xFilter + " order by sh.created_on desc";

            xDb.LoadGrid(xQuery, dataGridView2);
            dataGridView2.Columns["created_on"].DefaultCellStyle.Format = "dd /MMMM/yyyy hh:mm:ss";
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

      
    }
}
