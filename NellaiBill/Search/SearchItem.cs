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
    public partial class SearchItem : Form
    {

        DatabaseConnection xDb = new DatabaseConnection();

        public string xStockId { get; set; }
        public string xItemNo { get; set; }
        public string xItemName { get; set; }
        public string xStock { get; set; }

        public string xUnitPrice { get; set; }
        public string xMrp { get; set; }


        public string xBatch { get; set; }
        public string xExpDate { get; set; }
        public string xTax { get; set; }

        public string xFormType { get; set; }
        public SearchItem(string xForm)
        {
            InitializeComponent();
            xFormType = xForm;
        }

        private void SearchItem_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //refer key activities
            xItemNo = "0";
            txtSearch.Select();
            if (xFormType == "purchase")
            {
                
                xDb.LoadGrid("select 0,i.product_id,i.product_name,0,0,'','',i.gst from m_product i " +
                      "  order by product_name", dataGridView1);
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].FillWeight = 200;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;//expiry_date
            
            }
            else
            {
                xDb.LoadGrid("select s.stock_id,s.product_id,i.product_name,s.qty,s.mrp,s.batch_id,s.expiry_date,i.gst from stock s,m_product i " +
                    " where s.qty>0 and  s.product_id = i.product_id order by product_name", dataGridView1);

                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[6].Visible = false;//expiry_date
                dataGridView1.Columns[2].FillWeight = 200;
                dataGridView1.Columns[3].FillWeight = 60;
                dataGridView1.Columns[4].FillWeight = 60;
                dataGridView1.Columns[5].FillWeight = 60;
            }
            
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "product_name Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xStockId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).ToString();
            xItemNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()).ToString();
            xItemName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (xItemName == "")
            {
                MessageBox.Show("Please select different Item");
                return;
            }
            xStock = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (xFormType != "purchase")
            {

                /*Included Gst Logic */
                double xUnitMrp = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                double xGstBefore = double.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString()) / 100 + 1;
                double xUnitRate = (((xUnitMrp / xGstBefore)));

                xUnitPrice = xUnitRate.ToString("#.##");
                xMrp = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                xBatch = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                xExpDate = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
             
            }
            xTax = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            this.Close();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                DataGridViewRow dgr = dataGridView1.CurrentRow;
                xStockId = Convert.ToInt32(dgr.Cells[0].Value.ToString()).ToString();
                xItemNo = Convert.ToInt32(dgr.Cells[1].Value.ToString()).ToString();
                xItemName = dgr.Cells[2].Value.ToString();
                if (xItemName == "")
                {
                    MessageBox.Show("Please select different Item");
                    return;
                }
                xStock = dgr.Cells[3].Value.ToString();
                if (xFormType == "purchase")
                {
                }
                else
                {
                    /*Included Gst Logic */
                    double xUnitMrp = double.Parse(dgr.Cells[4].Value.ToString());
                    double xGstBefore = double.Parse(dgr.Cells[7].Value.ToString()) / 100 + 1;
                    double xUnitRate = (((xUnitMrp / xGstBefore)));

                    xUnitPrice = xUnitRate.ToString("#.##");
                    xMrp = dgr.Cells[4].Value.ToString();

                    xBatch = dgr.Cells[5].Value.ToString();
                    xExpDate = dgr.Cells[6].Value.ToString();
                    
                }
                xTax = dgr.Cells[7].Value.ToString();
                this.Close();
            }
        }

        private void SearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }
    }
}
