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
    public partial class LabEntry : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public LabEntry()
        {
            InitializeComponent();
        }

        private void LabEntry_Load(object sender, EventArgs e)
        {
            //btnLabEntryUpdate.Enabled = false;
        }

        private void btnViewLabEntry_Click(object sender, EventArgs e)
        {
  
            if (txtLabId.Text == "")
            {
                MessageBox.Show("Please Enter Lab Id ");
                txtLabId.Focus();
                return;
            }
            LoadGrid();
            dataGridView1.Columns[0].Visible = false;
            
        }
        private void LoadGrid()
        {
           string xQuery = "select  bb.id as Id,i.itemname as ITEM_NAME,bb.lab_details as RESULT_ENTRY from basic_billing bb ,m_item i where i.itemno=bb.itemno " +
                " and salesid=" + txtLabId.Text + "";

            xDb.LoadGrid(xQuery, dataGridView1);
            txtLabId.Text = "";
            //btnLabEntryUpdate.Enabled =true;
            //btnViewLabEntry.Enabled = false;
        }

        private void btnLabEntryUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
               
                int xId = Convert.ToInt32(dr.Cells["Id"].Value);
                string xResultEntry = dr.Cells["RESULT_ENTRY"].Value.ToString();
                string xQry = "update basic_billing " +
                  " set lab_details='" + xResultEntry + "' " +
                  " where  id= " + xId + "";
                xDb.DataProcess(xQry);
                MessageBox.Show("Report Updated");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
