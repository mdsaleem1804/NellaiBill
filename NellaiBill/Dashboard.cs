using NellaiBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            String xDate = DateTime.Now.ToString("yyyy-MM-dd");
            DatabaseConnection xDb = new DatabaseConnection();
            Backup xBackUp = new Backup();
            ConfigResponseModel configResponse = xDb.GetConfig();
            xBackUp.BackUpDatabase(configResponse.BackUpPath);
            BackUpResponseModel backupResponse = xDb.GetBackUpHistory(xDate);
            if (backupResponse.BackUpPath == null)
            {
                string xQry = "insert into backup (date,path) " +
                    " values('" + xDate + "','" + configResponse.BackUpPath + "')";
                xDb.DataProcess(xQry);
            }
           
        }
    }
}
