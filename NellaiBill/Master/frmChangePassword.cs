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
    public partial class frmChangePassword : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        string xTableName = "m_user";
        
        int xUserID;
        string xPassWord;

        public frmChangePassword()
        {
            InitializeComponent();
        }

        public void Dataprocess()
        {
            if (txtEmailId.Text == "")
            {
                MessageBox.Show("Please Enter Email Id");
                txtEmailId.Focus();
                return;
            }

            string xUserEmail = txtEmailId.Text.ToString();
            string xPassWord = xDb.GetUserDetailFromEmailId(xUserEmail).PassWord;
            if (txtOldPassword.Text == xPassWord)
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    string xQry = "update " + xTableName + " set password = '" + txtNewPassword.Text + "'  where  email_id= '" + xUserEmail + "'";
                    xDb.DataProcess(xQry);
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Password mismatch");
                }
            }
            else
            {
                MessageBox.Show("Your Old PassWord is incorrect");
            }

        } 
         

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            Dataprocess();
        }

      
        private void ClearData()
        {
            txtEmailId.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtOldPassword.Text = "";
        }

        private void btncancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
