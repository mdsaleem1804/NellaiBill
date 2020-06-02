using NellaiBill.Transaction;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace NellaiBill.Master
{
    public partial class Login : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(xDb.CountRecord("select * from m_user where username='" + txtUserName.Text+ "' and password='"+txtPassword.Text+"'")>=1)
            //if((txtUserName.Text=="admin") && (txtPassword.Text=="admin"))
            {
                frm_main_mdi nextForm = new frm_main_mdi();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();

                //OutPatientEntry nextForm = new OutPatientEntry();
                //this.Hide();
                //nextForm.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Login Credentials Wrong");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string xMacAddress = "";
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
            if (xDb.GetTotalCount("select * from m_user where password='" + xEncrypted + "'") ==1)
            {       
               
            }
            else
            {
                //Activation xActivation = new Activation();
                //this.Hide();
                //xActivation.ShowDialog();
                //this.Close();

            }

        }

        
        private void DataClear()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataClear();
        }
    }
}
