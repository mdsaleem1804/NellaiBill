using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill
{
    public partial class YearEnd : Form
    {
        MySqlConnection connection;
        string xHostName;
        string xUserName;
        string xPassword;
        string xDatabaseName;
        string xTableName ;

        string xCurrentDateTime ="_"+  DateTime.Now.Year.ToString();
        

        public YearEnd()
        {
            InitializeComponent();
        }
        

        private void step_1_Click(object sender, EventArgs e)
        {          
            string renameQry = "rename table " + xDatabaseName+ "." + xTableName+ " to " + xDatabaseName+ "." + xTableName+ "" + xCurrentDateTime+ ";";
            connection.Open();
            MySqlCommand command = new MySqlCommand(renameQry, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void step_2_Click(object sender, EventArgs e)
        {
            string renameQry = "create table " + xDatabaseName + "." + xTableName + " like " + xDatabaseName + "." + xTableName + "" + xCurrentDateTime + ";";
            connection.Open();
            MySqlCommand command = new MySqlCommand(renameQry, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void YearEnd_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            
            string xFileName = openFileDialog1.FileName;
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
                    if (i == 4)
                        xTableName = lines[4];
                }          

            }
            else
            {
                MessageBox.Show("No File");
            }
           
         connection   = new MySqlConnection(
                "Datasource=" + xHostName + ";" +
"port=3306;username=root;password=");
          
        }
    }
}
