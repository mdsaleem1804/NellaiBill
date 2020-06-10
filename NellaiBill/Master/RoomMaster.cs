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
    public partial class RoomMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public RoomMaster()
        {
            InitializeComponent();
        }

        private void RoomMaster_Load(object sender, EventArgs e)
        {

            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
        }
        private void LoadGrid()
        {
            string xQuery = "select room_id,room_name as RoomName,amount as Amount from m_room";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }
        private void DataClear()
        {
            txtRoomName.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtRoomName.Focus();
        }
    }
}
