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
            string xQuery = "select case_type_id,case_type_name as CaseTypeName from m_case_type";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }
        private void DataClear()
        {
            txtCaseTypeName.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtCaseTypeName.Focus();
        }
    }
}
