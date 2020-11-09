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
    public partial class StockDetailBetweenDate : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public StockDetailBetweenDate()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            if (Convert.ToInt32(cmbProductName.SelectedValue)==0)
            {
                List<int> xProductIDs = xDb.GetStockProductIDs();
                foreach (var id in xProductIDs)
                {
                    GetStockValues(id);
                }
            }

            else
            {
                GetStockValues(Convert.ToInt32(cmbProductName.SelectedValue));

            }

          

        }

        private void GetStockValues(int xId)
        {
            string xFromDate = dtpFromDate.Text;
            string xToDate = dtpToDate.Text;
            int xPurchaseQtyBeforeFromDate = xDb.GetTotalCount("select  IFNULL(SUM(qty), 0) as qty from purchase_details pd , " +
                  " purchase p where p.purchase_id = pd.purchase_id " +
                  " and p.date < '" + xFromDate + "' " +
                  " and pd.product_id = " + xId);

            string xProductName = xDb.GetProductFromProductId("select * from m_product where product_id=" + xId).ProductName;

            int xPurchaseReturnQtyBeforeFromDate = xDb.GetTotalCount("SELECT IFNULL(SUM(qty), 0) AS total  " +
                " FROM purchase_return p " +
                " where p.date < '" + xFromDate + "' " +
                " and p.product_id = " + xId);

            int xSalesQtyBeforeFromDate = xDb.GetTotalCount("select  IFNULL(SUM(qty), 0) as qty from sales_details sd , " +
                " sales s where s.sales_id = sd.sales_id " +
                " and s.date < '" + xFromDate + "' " +
                " and sd.product_id = " + xId);

            int xSalesReturnQtyBeforeFromDate = xDb.GetTotalCount("SELECT IFNULL(SUM(qty), 0) AS total  " +
              " FROM sales_return s " +
               " where s.date < '" + xFromDate + "' " +
                " and s.product_id  = " + xId);
            int xOpeningStock = xPurchaseQtyBeforeFromDate - xPurchaseReturnQtyBeforeFromDate - xSalesQtyBeforeFromDate + xSalesReturnQtyBeforeFromDate;
            int xPurchaseQty = xDb.GetTotalCount("select  IFNULL(SUM(qty), 0) as qty from purchase_details pd , " +
                " purchase p where p.purchase_id = pd.purchase_id " +
                " and p.date >= '" + xFromDate + "' " +
                " and p.date <= '" + xToDate + "' " +
                " and pd.product_id  = " + xId);


            int xPurchaseReturnQty = xDb.GetTotalCount("SELECT IFNULL(SUM(qty), 0) AS total  " +
                " FROM purchase_return p " +
                " where p.date >= '" + xFromDate + "' " +
                " and p.date <= '" + xToDate + "' " +
                " and p.product_id  = " + xId);

            int xSalesQty = xDb.GetTotalCount("select  IFNULL(SUM(qty), 0) as qty from sales_details sd , " +
                " sales s where s.sales_id = sd.sales_id " +
                " and s.date >= '" + xFromDate + "' " +
                " and s.date <= '" + xToDate + "' " +
                " and sd.product_id  = " + xId);

            int xSalesReturnQty = xDb.GetTotalCount("SELECT IFNULL(SUM(qty), 0) AS total  " +
              " FROM sales_return s " +
               " where s.date >= '" + xFromDate + "' " +
                " and s.date <= '" + xToDate + "' " +
                " and s.product_id  = " + xId);

            int xClosingStock = xOpeningStock + xPurchaseQty - xPurchaseReturnQty - xSalesQty + xSalesReturnQty;
            this.dataGridView1.Rows.Add(
              xProductName, xOpeningStock, xPurchaseQty, xPurchaseReturnQty, xSalesQty, xSalesReturnQty, xClosingStock);
        }
        private void StockDetailBetweenDate_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns[0].Width = 350;
            xDb.LoadComboBoxForReport("select product_id,product_name from m_product", cmbProductName, "product_id", "product_name");
        }
    }
}
