using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NellaiBill.Models;
namespace NellaiBill
{
    public partial class frmSettings : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        string xTableName = "config";
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            DataProcess();
        }

        private void DataProcess()
        {
            //string xHms = cmbHMS.Text.ToString();
            //string xgethms = xDb.GetConfigForm(xHms).is_hms;
            //string xAccounts = cmbAccounts.Text.ToString();
            //string xgetAccounts = xDb.GetConfigForm(xAccounts).is_accounts;
            string xQry = "update config set is_hms='" + cmbHMS.Text.ToString() + "'  , is_accounts='" + cmbAccounts.Text.ToString() + "' , is_batch= '" + cmbBatch.Text.ToString() + "' , is_expiry= '" + cmbExpiry.Text.ToString() + "', backup_path= '" + txtFilePath.Text.ToString() + "' , is_m_hsn_code= '" + cmbHsnCode.Text.ToString() + "' , is_m_product_name_in_tamil= '" + cmbProductNameTamil.Text.ToString() + "' , is_m_product_code= '" + cmbProductCode.Text.ToString() + "' , is_m_product_mrp= '" + cmbProductMrp.Text.ToString() + "' , doctor_id='"+cmbDoctorId.Text+"' where config_id=0";
            xDb.DataProcess(xQry);
            MessageBox.Show("Updated");
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            ConfigModel configModelResponse = new ConfigModel();
            configModelResponse = xDb.GetConfig(0);
            cmbHMS.SelectedItem = configModelResponse.is_hms;
            cmbAccounts.SelectedItem = configModelResponse.is_accounts;
            cmbBatch.SelectedItem = configModelResponse.is_batch;
            cmbExpiry.SelectedItem = configModelResponse.is_expiry;
            txtFilePath.Text = configModelResponse.backup_path;
            cmbHsnCode.SelectedItem = configModelResponse.is_m_hsn_code;
            cmbProductNameTamil.SelectedItem = configModelResponse.is_m_product_name_in_tamil;
            cmbProductCode.SelectedItem = configModelResponse.is_m_product_code;
            cmbProductMrp.SelectedItem = configModelResponse.is_m_product_mrp;

            xDb.LoadComboBox("select doctor_id,doctor_name from m_doctor", cmbDoctorId, "doctor_id", "doctor_name");
            //cmbDoctorId.SelectedValue = configModelResponse.doctor_id;
            cmbDoctorId.SelectedIndex = configModelResponse.doctor_id;

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
