using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NellaiBill.Master
{
    public partial class EcgXrayLab : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        DataTable table = new DataTable();
        int xItemId;

        public EcgXrayLab()
        {
            InitializeComponent();
        }

        private void EcgXrayLab_Load(object sender, EventArgs e)
        {
            LoadItemName();
            //LoadCustomerName();
            SetDataTableColumn();

            dataGridView1.ReadOnly = true;
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);



        }
        private void LoadItemName()
        {
            xDb.LoadComboBox("select itemno,itemname from m_item", cmb_item, "itemno", "itemname");
        }
        private void LoadCustomerName()
        {
          //  xDb.LoadComboBox("select account_ledger_id,ledger_name  from account_ledger where ledger_undergroup_no=5 ", cmb_customer, "account_ledger_id", "ledger_name");
        }

        private void cmb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            xItemId = Int32.Parse(cmb_item.SelectedValue.ToString());
            MySqlConnection connection;
            string conString = @"Data Source=localhost;port=3306;Initial Catalog=billing;User Id=root;password=";
            connection = new MySqlConnection(conString);
            string selectQuery = "select price from m_item where itemno =" + xItemId;
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txt_mrp.Text = reader[0].ToString();

            }
            connection.Close();
        }

        private void SetDataTableColumn()
        {

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(double));

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddDataToGrid();
        }


        private void AddDataToGrid()
        {
            try
            {

                double xAmount = double.Parse(txt_mrp.Text);
                table.Rows.Add(Int32.Parse(cmb_item.SelectedValue.ToString()),
                    cmb_item.Text, xAmount);
                dataGridView1.DataSource = table;
                CalculateGridTotalValue();
            }
            catch (Exception e)
            {
                string x = e.ToString();
            }
        }
        private void CalculateGridTotalValue()
        {

           double xTotalAmount = 0;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {

                xTotalAmount += Convert.ToDouble(dr.Cells["Price"].Value);
            }
            lbl_total_amount_value.Text = xTotalAmount.ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateGridTotalValue();
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            if(txtHospitalId.Text=="")
            {
                MessageBox.Show("Please Enter Hospital Id");
                txtHospitalId.Focus();
                return;
            }
            if(dataGridView1.Rows.Count>=1)
            {
                int xSalesId = xDb.GetMaxId("sales_id","sales_history");
                
                string xBillDate = dateTimePicker1.Text.ToString();
                double xPrice = 0;
                double xQty = 0;
                double xTotalPrice = 0;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    xQty = 1;
                    xPrice = Convert.ToDouble(dr.Cells["Price"].Value);
                   int xItemNo = Convert.ToInt32(dr.Cells["Id"].Value);
                    xTotalPrice = xQty * xPrice;
                    string xQry = "insert into   basic_billing" +
                       "(salesid,date,name,itemno,qty,price,total) " +
                       "values(" + xSalesId + "," +
                       " '" + xBillDate + "'," +
                       " '" + txtHospitalId.Text + "'," +
                       " " + xItemNo + "," +
                       " " + xQty + "," +
                       " " + xPrice + "," +
                       " " + xTotalPrice + " )";
                    xDb.DataProcess(xQry);
                    
                }
                table.Rows.Clear();
                MessageBox.Show("Record Saved Succesfully Id is " + xSalesId);
                //printDocument1.Print();
     
            }
            else
            {
                MessageBox.Show("Please Add Data Before Save");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
