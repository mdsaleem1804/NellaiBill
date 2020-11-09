using MySql.Data.MySqlClient;
using NellaiBill.Common;
using NellaiBill.Models;
using System;
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

            try
            {
                if (txtFilePath.Text == "")
                {
                    MessageBox.Show("Please Choose Folder");
                    return;
                }
    

                BackUpDatabase(txtFilePath.Text);
                MessageBox.Show("Back up completed");
            }
            catch (Exception ex )
            {
                MessageBox.Show("Some Error - Back up not completed" + ex);
            }

        }

        public void BackUpDatabase(string file)
        {
            CompanyInfoResponseModel response = xDb.GetCompanyDetails();
            string xCompanyName = response.CompanyTitle;
            string xCurrentDateTime = DateTime.Now.ToString("ddMMMMyyyy_h_mm_tt");
            string xFileName = file + "\\" + xCompanyName + "_" + xCurrentDateTime + ".sql";
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
                        mb.ExportInfo.ExportRows = true;
                        mb.ExportToFile(xFileName);
                        xDb.connection.Close();
                    }
                }
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
            //Issue Solved via https://www.codeproject.com/Questions/1246134/Csharp-textbox-not-contains-backslash-while-insert 
            // To be concentrate sql injection in future

            string xCSharpMySqlPath = folderPath.Replace("\\", "\\\\");
            
            string xQry = "update config set backup_path='" + xCSharpMySqlPath + "'";
            xDb.DataProcess(xQry);
            MessageBox.Show("Path Setting - Done");
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            //ConfigResponseModel model = xDb.GetConfig();
            //txtFilePath.Text= model.BackUpPath;
            //if(LoginInfo.UserID== "Developer")
            //{
            //    grpRestore.Visible = true;
            //}
            //string xQuery = "select date as Date,path as Path from backup";
            
            //xDb.LoadGrid(xQuery, dataGridView1);
            //dataGridView1.Columns[0].Width = 200;
        }

        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = openFileDialog.FileName;
            }
            txtRestoreFilePath.Text = folderPath;;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            
            string xRestoreFilePath = txtRestoreFilePath.Text;
              using (MySqlConnection conn = new MySqlConnection(xDb.conString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(xRestoreFilePath);
                        conn.Close();
                    }
                }
            }
            MessageBox.Show(" Restore completed");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
