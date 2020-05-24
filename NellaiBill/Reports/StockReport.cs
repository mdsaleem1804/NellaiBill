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
            xDb.LoadComboBox("select i.itemno,i.itemname from m_item i", cmbItem, "itemno", "itemname");

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
            string xQuery = "SELECT i.itemname, s.stock, s.mrp, s.batch,s.expdate FROM inv_stockentry s, m_item i WHERE i.itemno = s.itemno " + xQry;

            xDb.LoadGrid(xQuery, dataGridView1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "itemname Like '%" + txtSearch.Text +  "%'";
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
                xFilter += " and audit_stock_itemno=" + xItemNo;
            }
            dataGridView2.ReadOnly = true;
            //DateTime xFromDate = DateTime.ParseExact(dtpFromDate.Text, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            //DateTime xToDate = DateTime.ParseExact(dtpToDate.Text, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            string xQuery = "select i.itemname as ITEM_NAME,a.audit_stock_qty as QTY," +
                " a.audit_stock_batch as BATCH,a.audit_stock_mrp as MRP," +
                " a.audit_stock_datetime as DATETIME,a.audit_stock_mode as DETAILS " +
                " from audit_stock a,m_item i where i.itemno=a.audit_stock_itemno " +
                " and audit_stock_datetime>='" + Convert.ToDateTime(dtpFromDate.Text).ToString("yyyy-MM-dd HH:mm:ss") + "' and audit_stock_datetime <= '" + Convert.ToDateTime(dtpToDate.Text).ToString("yyyy-MM-dd HH:mm:ss") + "' " + xFilter + " order by audit_stock_datetime desc";

            xDb.LoadGrid(xQuery, dataGridView2);
            dataGridView2.Columns["DATETIME"].DefaultCellStyle.Format = "dd /MMMM/yyyy hh:mm:ss";
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

      
    }
}
