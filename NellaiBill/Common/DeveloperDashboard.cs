using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Common
{
    public partial class DeveloperDashboard : Form
    {
        public DeveloperDashboard()
        {
            InitializeComponent();
        }

        private void DeveloperDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
    
            string connStr = "server=localhost;user=root;port=3306;password=nellaibill;";
            //if (DBExists( connStr, "hms_lhs"))
            //{
            //    MessageBox.Show("Database Exists");
            //}
            //else
            //{
                using (var conn = new MySqlConnection(connStr))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `hms_lhs`;";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Database Created");
           // }

        }
        public bool DBExists(string conn, string dbName)
        {
            bool functionReturnValue = false;

            using (MySqlConnection dbconn = new MySqlConnection(conn))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM " +
                    " information_schema.schemata WHERE SCHEMA_NAME=@dbName"))
                {
                    functionReturnValue = false;
                    cmd.Parameters.AddWithValue("@dbName", dbName);
                    dbconn.Open();
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        functionReturnValue = true;
                    }
                    dbconn.Close();
                }
            }
            return functionReturnValue;
        }
        private void btnBackUpRestore_Click(object sender, EventArgs e)
        {

            Backup nextForm = new Backup();
            nextForm.ShowDialog();
        }
    }
}
