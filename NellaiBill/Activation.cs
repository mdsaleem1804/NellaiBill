using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace NellaiBill
{
    public partial class Activation : Form
    {
        string xMacAddress = "TEST";
        public Activation()
        {
            InitializeComponent();
        }

        private void btnCheckInternetConnection_Click(object sender, EventArgs e)
        {

            if (CheckInternetConnection() == true)
            {
                MessageBox.Show("Internet is available");

            }
            else
            {
                MessageBox.Show("Please recheck your connection");
            }
        }
        public bool CheckInternetConnection()
        {

            bool connection = NetworkInterface.GetIsNetworkAvailable();
            return connection;
        }
        private void Activation_Load(object sender, EventArgs e)
        {

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        xMacAddress = nic.GetPhysicalAddress().ToString();
                    }
                }
            }

            string xEncrypted = CryptoEngine.Encrypt(xMacAddress, "sblw-3hn8-sqoy19");
            string xDecrypted = CryptoEngine.Decrypt(xEncrypted, "sblw-3hn8-sqoy19");


        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (mtxt_Key.Text == "")
            {
                MessageBox.Show("Please Enter Key Here");
                mtxt_Key.Focus();
            }
            else
            {
                if (CheckInternetConnection() != true)
                {
                    MessageBox.Show("Please recheck your connection");
                }
                else
                {
                    string url = string.Format("https://samples.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=b6907d289e10d714a6e88b30761fae22");
                    using (WebClient client = new WebClient())
                    {
                        string json = client.DownloadString(url);

                        WeatherInfo weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);

                        MessageBox.Show(weatherInfo.coord.lon);
                    }

                }


            }
        }
    }
    public class CryptoEngine
    {
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
    public class WeatherInfo
    {
        public City coord { get; set; }

    }
    public class City
    {
        public string lon { get; set; }

    }

}
