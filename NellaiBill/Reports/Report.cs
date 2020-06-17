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
    public partial class Report : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public Report()
        {
            InitializeComponent();
        }

        private void btnReportView_Click(object sender, EventArgs e)
        {
            LoadGrid();
           CalculateGridTotalValue();
        }
        private void LoadGrid()
        {
            dataGridView1.ReadOnly = true;
            string xQuery = "select  bb.salesid as BILL_NO,bb.name as PATIENT_NAME,i.product_name as ITEM_NAME,bb.total as AMOUNT from basic_billing bb ,m_product i where i.product_id=bb.product_id " +
                " and date>='" + dtpFromDate.Text + "' and date <= '"+dtpToDate.Text + "'" ;

            xDb.LoadGrid(xQuery, dataGridView1);
        }
        private void CalculateGridTotalValue()
        {

            double xTotalAmount = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                xTotalAmount += Convert.ToDouble(dr.Cells["AMOUNT"].Value);
            }
            lbl_total_amount_value.Text = xTotalAmount.ToString();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
        }
    }
}
