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
    public partial class frmForgetPassword : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        string xTableName = "m_user";
        int xUserID;

        public frmForgetPassword()
        {
            InitializeComponent();
        }
        public void Dataprocess()
        {

            string xUserEmail=txtEmail.Text.ToString();
            string xQry = "select * from m_user where email_id='" + xUserEmail + "'";
            if (xDb.CountRecord(xQry) >= 1)
            {
                string xUserPassword=xDb.GetUserDetailFromEmailId(xUserEmail).PassWord;

                MessageBox.Show("Record Found and your password is " + xUserPassword );
                return;

            } 

        }
        private void btnpasswordupdate_Click(object sender, EventArgs e)
        {
            Dataprocess();
            this.Close();
           
        }
    }
}
