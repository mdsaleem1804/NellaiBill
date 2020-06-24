using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Common
{
    public partial class DeveloperDashboard : Form
    {
        static string xHostName = ConfigurationManager.AppSettings["server"].ToString();
        static string xPort = ConfigurationManager.AppSettings["port"].ToString();
        static string xUserName = ConfigurationManager.AppSettings["username"].ToString();
        static string xPassword = ConfigurationManager.AppSettings["password"].ToString();
        static string xDatabaseName = ConfigurationManager.AppSettings["database"].ToString();
        public string conString =
        @"Data Source=" + xHostName + ";" +
        "port=" + xPort + ";" +
        "User Id=" + xUserName + ";" +
        "password=" + Decrypt(xPassword, "hana-sept-mber16") + "; Convert Zero Datetime=True;CharSet=utf8;";

        public DeveloperDashboard()
        {
            InitializeComponent();
        }

        private void DeveloperDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {   
           // string connStr = "server=localhost;user=root;port=3306;password=nellaibill;";
            //if (DBExists( connStr, "hms_lhs"))
            //{
            //    MessageBox.Show("Database Exists");
            //}
            //else
            //{
                using (var conn = new MySqlConnection(conString))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `hms_lhs`;";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Database Created");
           // }

        }
        public static string Decrypt(string input, string key)
        {
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
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
