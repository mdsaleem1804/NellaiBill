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

namespace NellaiBill.Master
{

    public partial class frmCompany : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        
        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            DataFetch();
        }

        private void mBtnUpdate_Click(object sender, EventArgs e)
        {
            string xQry = "update setup_companyinfo set " +
                " companytitle = '" + txtCompanyName.Text + " ', " +
                " companyaddress1='" + txtAddressLine1.Text + " ', " +
                " companyaddress2='" + txtAddressLine2.Text + " ', " +
                " companyaddress3='" + txtAddressLine3.Text + " ', " +
                " companycontactno='" + txtContactNo.Text + " ', " +
                 " gstinno='" + txtGSTINNo.Text + " ' ";
            xDb.DataProcess(xQry);
            MessageBox.Show("Company Info Updated");
            DataFetch();
        }
        private void DataFetch()
        {

            xDb.connection = new MySqlConnection(xDb.conString);
            xDb.connection.Open();
            MySqlCommand command = new MySqlCommand("select * from  setup_companyinfo where companyno=1", xDb.connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtCompanyName.Text = reader[1].ToString();
                txtAddressLine1.Text = reader[2].ToString();
                txtAddressLine2.Text = reader[3].ToString();
                txtAddressLine3.Text = reader[4].ToString();
                txtContactNo.Text = reader[5].ToString();
                txtGSTINNo.Text = reader[6].ToString();

            }
            xDb.connection.Close();
        }
    }
}
