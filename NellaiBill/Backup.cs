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

namespace NellaiBill
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }
        DatabaseConnection xDb = new DatabaseConnection();
        private void btnBackup_Click(object sender, EventArgs e)
        {
            string xCompanyName = "SHC";
            try
            {
                if(txtFilePath.Text=="")
                {
                    MessageBox.Show("Please Choose Folder");
                    return;
                }
                string file =   txtFilePath.Text + xCompanyName + "_" + DateTime.Now + "_" + "backup.sql";
                using (xDb.connection = new MySqlConnection(xDb.conString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = xDb.connection;
                            xDb.connection.Open();
                            mb.ExportInfo.AddCreateDatabase = true;
                            mb.ExportInfo.ExportTableStructure = true;
                            mb.ExportInfo.ExportRows = false;
                            mb.ExportToFile(file);
                            xDb.connection.Close();
                        }
                    }
                }
                MessageBox.Show("Back up completed");
            }
            catch(Exception ex )
            {
                MessageBox.Show("Some Error - Back up not completed" + ex);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }
            txtFilePath.Text = folderPath;
        }
    }
}
