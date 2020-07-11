using MySql.Data.MySqlClient;
using NellaiBill.Models;
using System;
using System.Collections.Generic;
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
        "password=" + Decrypt(xPassword, "hana-sept-mber16") + "; Convert Zero Datetime=True;CharSet=utf8;";

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
        //public void DataProcess1()
        //{
        //    MySqlDataAdapter da = new MySqlDataAdapter();
        //    MySqlCommand cmd;
        //    MySqlParameter parm;

        //    // Create the InsertCommand.
        //    cmd = new MySqlCommand("INSERT INTO mytable (id,name) VALUES (@id,@name)", new MySqlConnection(conString));
        //    cmd.Parameters.Add("@id", MySqlDbType.VarChar, 15, "id");
        //    cmd.Parameters.Add("@name", MySqlDbType.Nv, 15, "name");

        //    da.InsertCommand = cmd;

        //}
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
                //if (xId > 30)
                //{
                //    MessageBox.Show("Your Key is not Activted . \n" +
                //        "In Case you purchased this Software. \n" +
                //        "Please ask your Sales Person to Activate this product.");

                //    System.Windows.Forms.Application.Exit();
                //}
            }
            connection.Close();
            return xId;

        }

        public string GetUserNameFromPassword(string xPassword)
        {
            connection = new MySqlConnection(conString);
            string xQry = "select username from m_user where password= '" + xPassword + "'";
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
                    xGridView.AllowUserToAddRows = false;
                    //xGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    //xGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkMagenta;

                    xGridView.RowHeadersVisible = false;

                }
            }

        }

        public void LoadComboBoxForReport(string xQry, ComboBox xComboBox, string xValueMember, string xDisplayMember)
        {
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(xQry, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "All";
                    dt.Rows.InsertAt(row, 0);


                    xComboBox.ValueMember = xValueMember;
                    xComboBox.DisplayMember = xDisplayMember;
                    xComboBox.DataSource = dt;


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
                    if (xDisplayMember == "group_name" || xComboBox.Name == "cmbTest")
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
        public void LoadComboBoxData(string xQry, ComboBox xComboBox)
        {
            DataTable table = new DataTable("ip_admission");
            using (MySqlConnection conn = new MySqlConnection(conString))
            {

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(xQry, conn))
                {
                    adapter.Fill(table);
                }
            }
            foreach (DataRow da in table.Rows)
            {
                xComboBox.Items.Add(da[0].ToString());
            }
        }
        public void LoadComboBoxCell(string xQry, DataGridViewComboBoxCell xComboBox)
        {
            DataTable table = new DataTable("ip_admission");
            using (MySqlConnection conn = new MySqlConnection(conString))
            {

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(xQry, conn))
                {
                    adapter.Fill(table);
                }
            }
            foreach (DataRow da in table.Rows)
            {
                xComboBox.Items.Add(da[0].ToString());
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
        public bool OpenConnection()
        {
            try
            {
                connection = new MySqlConnection(conString);
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Cannot connect to server.  Please Turn On your Server");
                        System.Windows.Forms.Application.Exit();
                        break;
                }
                return false;
            }
        }

        public string GetTestFees(int xTestId)
        {
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "select amount from m_ecg_xray_test_fees where ecg_xray_test_fees_id= " + xTestId + "";
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
        }
        public string GetAdvancePaymentFromIpNo(int xIpNo)
        {
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "SELECT CASE WHEN sum(amount) IS NULL OR sum(amount) = '' THEN  0 ELSE sum(amount) END as amount from ip_advance_payment where ipno = " + xIpNo + "";
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
        }
        public ConfigResponseModel GetConfig()
        {
            ConfigResponseModel model = new ConfigResponseModel();
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "select * from config";
                connection.Open();
                MySqlCommand comm = new MySqlCommand(xQry, connection);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    model = new ConfigResponseModel()
                    {
                        BackUpPath = reader.GetString("backup_path"),
                        IsHms = reader.GetString("is_hms"),
                        IsAccounts= reader.GetString("is_accounts"),
                        IsBatch = reader.GetString("is_batch"),
                        IsExpiry = reader.GetString("is_expiry"),
                        IS_M_ProductnameInTamil = reader.GetString("is_m_product_name_in_tamil"),
                        IS_M_HsnCode = reader.GetString("is_m_hsn_code"),
                        IS_M_ProductCode = reader.GetString("is_m_product_code"),
                        IS_M_ProductMrp = reader.GetString("is_m_product_mrp")
                    };
                }
                connection.Close();
            }
            return model;
        }
        public BackUpResponseModel GetBackUpHistory(string xDate)
        {
            BackUpResponseModel model = new BackUpResponseModel();
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "select * from backup where date='" + xDate + "'";
                connection.Open();
                MySqlCommand comm = new MySqlCommand(xQry, connection);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    model = new BackUpResponseModel()
                    {
                        Date = reader.GetDateTime("date"),
                        BackUpPath = reader.GetString("path")
                    };
                }
                connection.Close();
            }
            return model;
        }
        public PatientResponseModel GetPatientFromPatientId(int xPatientId)
        {
            PatientResponseModel model = new PatientResponseModel();
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "select p.patient_id,p.uhid,p.patient_name,p.patient_address from " +
                    " m_patient_registration p " +
                    " where  p.patient_id = " + xPatientId + "";
                connection.Open();
                MySqlCommand comm = new MySqlCommand(xQry, connection);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    model = new PatientResponseModel()
                    {
                        PatientId = Convert.ToInt32(reader.GetInt32(0)),
                        UHID = reader.GetString(1),
                        PatientName = reader.GetString(2),
                        PatientAddress = reader.GetString(3)
                    };
                }
                connection.Close();
            }
            return model;
        }
        public DoctorResponseModel GetDoctorFromDoctorId(int xDoctorId)
        {
            DoctorResponseModel model = new DoctorResponseModel();
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "select * from m_doctor where  doctor_id = " + xDoctorId + "";
                connection.Open();
                MySqlCommand comm = new MySqlCommand(xQry, connection);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    model = new DoctorResponseModel()
                    {
                        DoctorId = Convert.ToInt32(reader.GetInt32(0)),
                        DoctorName = reader.GetString(1)
                    };
                }
                connection.Close();
            }
            return model;
        }
        public IPDetailModel GetIpDetailsFromIpNo(int xIpNo)
        {
            IPDetailModel model = new IPDetailModel();
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "select p.patient_id,p.patient_name,p.patient_address," +
                    "ip.room_id,doctor_id,case_type_id  from " +
                    " ip_admission ip, " +
                    " m_patient_registration p " +
                    " where " +
                    " p.patient_id = ip.patient_id " +
                    " and ip.ipno  = " + xIpNo + "";
                connection.Open();
                MySqlCommand comm = new MySqlCommand(xQry, connection);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    model = new IPDetailModel()
                    {
                        PatientId = Convert.ToInt32(reader.GetInt32(0)),
                        PatientName = reader.GetString(1),
                        PatientAddress = reader.GetString(2),
                        RoomId = reader.GetInt32(3),
                        DoctorId = reader.GetInt32(4),
                        CaseTypeId = reader.GetInt32(5)
                    };
                }
                connection.Close();
            }
            return model;
        }
        public LabResponseModel GetLabRecordFromLabId(int xLabId)
        {
            LabResponseModel model = new LabResponseModel();
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "select * from billing_lab where lab_id  = " + xLabId + "";
                connection.Open();
                MySqlCommand comm = new MySqlCommand(xQry, connection);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    model = new LabResponseModel()
                    {
                        PatientId = Convert.ToInt32(reader.GetInt32("patient_id")),
                        DoctorId = Convert.ToInt32(reader.GetInt32("doctor_id")),
                        BillDate = reader.GetDateTime("created_on")
                    };
                }
                connection.Close();
            }
            return model;
        }
        public CompanyInfoResponseModel GetCompanyDetails()
        {
            CompanyInfoResponseModel model = new CompanyInfoResponseModel();
            using (connection = new MySqlConnection(conString))
            {
                string xQry = "select * from setup_companyinfo";
                connection.Open();
                MySqlCommand comm = new MySqlCommand(xQry, connection);

                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    model = new CompanyInfoResponseModel()
                    {
                        CompanyTitle = reader.GetString("companytitle")
                    };
                }
                connection.Close();
            }
            return model;
        }

        public List<int> GetStockProductIDs()
        {
            List<int> values = new List<int>();
            StockResponseModel model = new StockResponseModel();
            using (connection = new MySqlConnection(conString))
            {

                connection.Open();
                MySqlCommand comm = new MySqlCommand("select product_id from m_product", connection);
                MySqlDataReader reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    values.Add(reader.GetInt32("product_id"));
                };
            }
            connection.Close();
            return values;
        }

    public StockResponseModel GetStockFromQuery(String xQry)
    {
        StockResponseModel model = new StockResponseModel();
        using (connection = new MySqlConnection(conString))
        {

            connection.Open();
            MySqlCommand comm = new MySqlCommand(xQry, connection);

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                model = new StockResponseModel()
                {
                    StockId = reader.GetInt32("stock_id"),
                    ProductId = reader.GetInt32("product_id"),
                    Qty = reader.GetInt32("qty"),
                    Mrp = reader.GetDouble("mrp"),
                    Batch = reader.GetString("batch_id"),
                    ExpDate = reader.GetDateTime("expiry_date")
                };
            }
            connection.Close();
        }
        return model;
    }

    public ProductModel GetProductFromProductId(String xQry)
    {
        ProductModel model = new ProductModel();
        using (connection = new MySqlConnection(conString))
        {

            connection.Open();
            MySqlCommand comm = new MySqlCommand(xQry, connection);

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                model = new ProductModel()
                {
                    ProductId = reader.GetInt32("product_id"),
                    ProductName = reader.GetString("product_name"),
                    ProductCode = reader.GetString("product_code"),
                    Gst = reader.GetString("gst")
                };
            }
            connection.Close();
        }
        return model;
    }
    public string GetRoomFees(int xRoomId)
    {
        using (connection = new MySqlConnection(conString))
        {
            string xQry = "select amount from m_room where room_id= " + xRoomId + "";
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

    public string GetCaseTypeNameFromCaseTypeId(int xCaseTypeId)
    {
        string xCaseTypeName = "";
        using (connection = new MySqlConnection(conString))
        {
            string xQry = "select case_type_name from m_case_type where  case_type_id = " + xCaseTypeId + "";
            connection.Open();
            MySqlCommand comm = new MySqlCommand(xQry, connection);

            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                xCaseTypeName = reader.GetString(0);
            }
            connection.Close();
        }
        return xCaseTypeName;
    }
}
}
