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
    public partial class RoomMaster : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        GlobalClass xGlobal = new GlobalClass();
        int xRoomId;
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
            string xQuery = "select room_id,room_name as RoomName,amount as Amount from m_room order by room_name";
            xDb.LoadGrid(xQuery, dataGridView1);
            btnSaveUpdate.Text = "SAVE";
        }
        private void DataClear()
        {
            txtRoomName.Text = "";
            txtAmount.Text = "";
            btnSaveUpdate.Text = "SAVE";
            txtRoomName.Focus();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataProcess();
        }
        public void DataProcess()
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (txtRoomName.Text == "")
            {
                xGlobal.DisplayMessage("Fill Room Name");
                txtRoomName.Focus();
                return;
            }
            if (txtAmount.Text == "")
            {
                xGlobal.DisplayMessage("Fill Amount");
                txtAmount.Focus();
                return;
            }
            string xQry = "";
            if (btnSaveUpdate.Text == "SAVE")
            {
                xQry = "insert into   m_room (room_name,amount,created_by,created_on) values( '" + txtRoomName.Text + "', '" + txtAmount.Text + "','" + xUser + "','" + xCurrentDateTime + "' )";
            }
            else
            {
                xQry = "update m_room set " +
                    " room_name = '" + txtRoomName.Text + "',  " +
                    " amount = '" + txtAmount.Text + "',  " +
                    " updated_by = '" + xUser + "',  " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  room_id= " + xRoomId + "";
            }
            xDb.DataProcess(xQry);
            xGlobal.DisplayMessage("Record Saved / Updated");
            LoadGrid();
            DataClear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            xRoomId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtRoomName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnSaveUpdate.Text = "UPDATE";
        }
    }
}
