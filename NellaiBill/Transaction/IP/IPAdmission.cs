using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Transaction.IP
{
    public partial class IPAdmission : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public IPAdmission()
        {
            InitializeComponent();
        }

        private void IPAdmission_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox("select doctor_id,doctor_name from m_doctor", cmbDoctor, "doctor_id", "doctor_name");
            xDb.LoadComboBox("select room_id,room_name from m_room", cmbRoom, "room_id", "room_name");
            xDb.LoadComboBox("select case_type_id,case_type_name from m_case_type", cmbCaseType, "case_type_id", "case_type_name");
        }
    }
}
