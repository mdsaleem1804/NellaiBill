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
    public partial class StockReport : Form
    {

        DatabaseConnection xDb = new DatabaseConnection();
        public StockReport()
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
                xQry = "and s.stock>0";
            }
           else if (xStockType == "Zero Stock")
            {
                xQry = "and s.stock=0";
            }
            else if (xStockType == "Negative Stock")
            {
                xQry = "and s.stock<0";
            }
            else if (xStockType == "All Stock")
            {
                xQry = "";
            }
            dataGridView1.ReadOnly = true;
            //dataGridView1.Columns[0].Width = 200;
            string xQuery = "SELECT i.product_name, s.stock, s.mrp, s.batch_id,s.expiry_date FROM stock s, m_product i WHERE i.product_id = s.product_id " + xQry;

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
                xFilter += " and stock_history_itemno=" + xItemNo;
            }
            dataGridView2.ReadOnly = true;
            //DateTime xFromDate = DateTime.ParseExact(dtpFromDate.Text, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            //DateTime xToDate = DateTime.ParseExact(dtpToDate.Text, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string xQuery = "select i.product_name as ITEM_NAME,a.stock_history_qty as QTY," +
                " a.stock_history_batch as BATCH,a.stock_history_mrp as MRP," +
                " a.stock_history_datetime as DATETIME,a.stock_history_mode as DETAILS " +
                " from stock_history a,m_product i where i.product_id=a.stock_history_itemno " +
                " and stock_history_datetime>='" + Convert.ToDateTime(dtpFromDate.Text).ToString("yyyy-MM-dd HH:mm:ss") + "' and stock_history_datetime <= '" + Convert.ToDateTime(dtpToDate.Text).ToString("yyyy-MM-dd HH:mm:ss") + "' " + xFilter + " order by stock_history_datetime desc";

            xDb.LoadGrid(xQuery, dataGridView2);
            dataGridView2.Columns["DATETIME"].DefaultCellStyle.Format = "dd /MMMM/yyyy hh:mm:ss";
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

      
    }
}
