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
    public partial class PurchaseReportDG : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public PurchaseReportDG()
        {
            InitializeComponent();
        }



        private void PurchaseReportDG_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbItem.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadComboBox()
        {
            //xDb.LoadComboBox("select s.stockno,i.itemname from inv_stockentry s,m_item i " +
            //    " where s.itemno = i.itemno group by s.itemno", cmbItem, "stockno", "itemname");
            xDb.LoadComboBox("select i.itemno,i.itemname from m_item i", cmbItem, "itemno", "itemname");
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
                xFilter += " and p.itemno=" + xItemNo;
            }
            //if (mChkSelectAllSupplier.Checked)
            //{

            //}
            //else
            //{
            //    string xLedgerId = cmbLedger.SelectedValue.ToString();
            //    xFilter += " and s.customerno=" + xLedgerId;
            //}
            if (txtInvoiceNo.Text.Length > 0)
            {
                xFilter += " and p.purchaseinvoiceno= " + txtInvoiceNo.Text.ToString();
            }

            string xQuery = "SELECT p.purchaseinvoiceno as INVNO,p.date as DATE,i.itemname as ITEMNAME," +
                "p.batchid as BATCH,p.dateexpired as DATEEXPIRED,p.qty as QTY,p.freeqty as FREEQTY,p.packno as PACKNO," +
                "p.originalprice as HSR,p.vat as GST,p.nettotal as TOTAL " +
                "from inv_purchaseentry p ,m_item i where i.itemno=p.itemno " +
                " and date>='" + dtpFromDate.Text + "' and date <= '" + dtpToDate.Text + "' " + xFilter + " order by p.purchaseinvoiceno desc";

            xDb.LoadGrid(xQuery, dataGridView1);
            dataGridView1.Columns["ITEMNAME"].Width = 200;
            dataGridView1.Columns["DATE"].DefaultCellStyle.Format = "dd /MMMM/yyyy";
            dataGridView1.Columns["INVNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["QTY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["FREEQTY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["PACKNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["HSR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["GST"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = "Total";

            //dataGridView1.Rows.Add(null, null, null, null, null, null, null, null);
            //for (int i = 7; i < dataGridView1.Columns.Count; i++)
            //{
            //    int total = 0;
            //    for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            //    {
            //        total += Convert.ToInt32(dataGridView1.Rows[j].Cells[i].Value);
            //    }
            //    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = total;
            //}
        }
    }
}
