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
    public partial class UserMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xUserId;
        public UserMaster()
        {
            InitializeComponent();
        }

        private void UserMaster_Load(object sender, EventArgs e)
        {
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Width = 100;
        }
        private void LoadGrid()
        {
            string xQuery = "select * from m_user";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }


        private void DataClear()
        {
            ////.Text = "";
            //rchTextDescription.Text = "";
            //btnSaveUpdate.Text = "SAVE";
            //cmbTestGroup.SelectedIndex = 0;
            //cmbTestMode.SelectedIndex = 0;
            //txtTestName.Focus();
        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
