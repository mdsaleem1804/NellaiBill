using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace NellaiBill
{
    public class DatabaseConnection
    {
        static string xHostName = ConfigurationManager.AppSettings["server"].ToString();
        static string xPort = ConfigurationManager.AppSettings["port"].ToString();
        static string xUserName = ConfigurationManager.AppSettings["username"].ToString();
        static string xPassword = ConfigurationManager.AppSettings["password"].ToString();
        static string xDatabaseName = ConfigurationManager.AppSettings["database"].ToString();
        public string xReportPath = "";
             int xGBatch = 0;
        public MySqlConnection connection;
        // public string conString = @"Data Source=localhost;port=3306;Initial Catalog=nellai_billing;User Id=root;password=nellaibill";
        public string conString =
        @"Data Source=" + xHostName + ";" +
        "port=" + xPort + ";" +
        "Initial Catalog=" + xDatabaseName + ";" +
        "User Id=" + xUserName + ";" +
        "password=" + Decrypt(xPassword, "hana-sept-mber16") + "; Convert Zero Datetime=True";

        public DatabaseConnection()
        {
            string a = Encrypt("", "hana-sept-mber16");
        }
        public void DataProcess(string xQry, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(xQry, connection);
            command.ExecuteNonQuery();
        }
        public void ReportSettings()
        {
            connection = new MySqlConnection(conString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select report_path from config_path", connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                xReportPath = reader[0].ToString();
            }
            connection.Close();

        }
        public void DataProcess(string xQry)
        {
            connection = new MySqlConnection(conString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(xQry, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public int GetTotalCount(string xQry)
        {
            int xTotalCount = 0;
            connection = new MySqlConnection(conString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(xQry, connection);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                xTotalCount = Convert.ToInt32(mySqlDataReader.GetString(0));

            }
            connection.Close();
            return xTotalCount;

        }
        public long DataProcess_GetId(string xQry)
        {
            connection = new MySqlConnection(conString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(xQry, connection);
            command.ExecuteNonQuery();
            connection.Close();
            long id = command.LastInsertedId;
            return id;
        }

        public int GetMaxId(string xColumnName, string xTableName)
        {
            int xId = 0;
            connection = new MySqlConnection(conString);
            string xQry = "SELECT CASE WHEN MAX( " + xColumnName + " ) IS NULL OR MAX(" + xColumnName + ") = '' THEN  '1' ELSE MAX(" + xColumnName + ") + 1 END AS " + xColumnName + " FROM " + xTableName + "";
            connection.Open();
            MySqlCommand comm = new MySqlCommand(xQry, connection);

            MySqlDataReader currentLoggedInUser = comm.ExecuteReader();

            while (currentLoggedInUser.Read())
            {
                xId = Convert.ToInt32(currentLoggedInUser.GetString(0));

            }
            connection.Close();
            return xId;

        }

        public string GetUserNameFromPassword(string  xPassword)
        {
            connection = new MySqlConnection(conString);
            string xQry = "select username from m_login where password= '" + xPassword + "'";
            connection.Open();
            MySqlCommand comm = new MySqlCommand(xQry, connection);

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                return reader.GetString(0);

            }
            connection.Close();
            return "";

        }
        public string GetTokenNoForOP(string xQry)
        {
            connection = new MySqlConnection(conString);
           
            connection.Open();
            MySqlCommand comm = new MySqlCommand(xQry, connection);

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                return reader.GetString(0);

            }
            connection.Close();
            return "";

        }
        public bool CheckUserExists(string xPassword)
        {
            try
            {
               connection = new MySqlConnection(conString);
                string xQry = "SELECT * FROM `m_login` WHERE password='" + xPassword + "'";
                connection.Open();
                MySqlCommand comm = new MySqlCommand(xQry, connection);

                MySqlDataReader reader = comm.ExecuteReader();
                int xUserNo = 0;
                while (reader.Read())
                {
                    xUserNo = Convert.ToInt32(reader.GetString(0));

                }
                connection.Close();
                if (xUserNo > 0) return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error Occured " + ex.Message);
            }
            return false;
        }
        public void GetConfigValues()
        {
            connection = new MySqlConnection(conString);
            string xQry = "select batch,exp_date,stock,gst from config";
            connection.Open();
            MySqlCommand comm = new MySqlCommand(xQry, connection);

            MySqlDataReader mySqlDataReader = comm.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                xGBatch = Convert.ToInt32(mySqlDataReader.GetString(0));

            }
            connection.Close();

        }

        public void LoadDatabaseConfig()
        {
            string xFileName = "E:\\a.txt";
            if (File.Exists(xFileName) == true)
            {
                var lines = File.ReadAllLines(xFileName);
                for (var i = 0; i < lines.Length; i += 1)
                {
                    if (i == 0)
                        xHostName = lines[0];
                    if (i == 1)
                        xUserName = lines[1];
                    if (i == 2)
                        xPassword = lines[2];
                    if (i == 3)
                        xDatabaseName = lines[3];
                }

            }
            else
            {
                MessageBox.Show("No File");
            }
        }
        public void LoadGrid(string xQry, DataGridView xGridView)
        {

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(xQry, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    xGridView.DataSource = ds.Tables[0];
                    xGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    xGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
                    //xGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    //xGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkMagenta;

                    xGridView.RowHeadersVisible = false;

                }
            }

        }

    
        public void LoadComboBox(string xQry, ComboBox xComboBox, string xValueMember, string xDisplayMember)
        {
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(xQry, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (xDisplayMember == "itemgroupname")
                    {

                    }
                    else
                    {
                        DataRow row = dt.NewRow();
                        row[0] = 0;
                        row[1] = "Please select";
                        dt.Rows.InsertAt(row, 0);
                    }

                    xComboBox.ValueMember = xValueMember;
                    xComboBox.DisplayMember = xDisplayMember;
                    xComboBox.DataSource = dt;
                   
                   
                }
            }



        }
        public void LoadComboBox1(string xQry, ComboBox xComboBox, string xValueMember, string xDisplayMember)
        {
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(xQry, conn))
                {
                    try
                    {
                        MySqlConnection connection = new MySqlConnection(conString);

                        connection.Open();
                        MySqlCommand command = new MySqlCommand(xQry, connection);
                        MySqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            xComboBox.Items.Add(reader.GetString(xDisplayMember));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }



        }

        public int CountRecord(string xQry)
        {
            MySqlConnection con = new MySqlConnection(conString);
            int i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = xQry;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = dt.Rows.Count;
            return i;
        }

        public static string Encrypt(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
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

    }
}
