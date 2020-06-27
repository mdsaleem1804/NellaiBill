using NellaiBill.Common;
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
    public partial class CaseTypeMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        GlobalClass xGlobal = new GlobalClass();
        int xCaseTypeId;
        public CaseTypeMaster()
        {
            InitializeComponent();
        }

        private void CaseTypeMaster_Load(object sender, EventArgs e)
        {
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }
        private void LoadGrid()
        {
            string xQuery = "select case_type_id,case_type_name as CaseTypeName from m_case_type order by case_type_name ";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }
        private void DataClear()
        {
            txtCaseTypeName.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtCaseTypeName.Focus();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataProcess();
        }
        public void DataProcess()
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (txtCaseTypeName.Text == "")
            {
                xGlobal.DisplayMessage("Fill Category Name");
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into   m_case_type (case_type_name,created_by,created_on) values( '" + txtCaseTypeName.Text + "','" + xUser + "','" + xCurrentDateTime + "' )";
            }
            else
            {
                xQry = "update m_case_type set " +
                    " case_type_name = '" + txtCaseTypeName.Text + "',  " +
                    " updated_by = '" + xUser + "',  " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  case_type_id= " + xCaseTypeId + "";
            }
            xDb.DataProcess(xQry);
            xGlobal.DisplayMessage("Record Saved / Updated");
            LoadGrid();
            DataClear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xCaseTypeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtCaseTypeName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
        }
    }
}
