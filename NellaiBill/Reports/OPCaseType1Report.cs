using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Reports
{
    public partial class OPCaseType1Report : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        ReportDocument cryRpt = new ReportDocument();
        GlobalClass globalClass = new GlobalClass();
        public OPCaseType1Report()
        {
            InitializeComponent();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            if (cmbCaseType1.SelectedItem == "" || cmbCaseType1.SelectedItem == null)
            {
                MessageBox.Show("Please Choose CaseType");
                cmbCaseType1.Select();
                return;
            }
            if (cmbDoctorName.SelectedItem == "" || cmbDoctorName.SelectedItem == null)
            {
                MessageBox.Show("Please Choose DoctorName");
                cmbDoctorName.Select();
                return;
            }
            string xFromDate = dtpFromDate.Text;
            string xToDate = dtpToDate.Text;
            string path = globalClass.GetReportPath() + "rptOPCaseType1.rpt";
            cryRpt.Load(path);

            cryRpt.SetParameterValue("FromDate", DateTime.Parse(xFromDate));
            cryRpt.SetParameterValue("ToDate", DateTime.Parse(xToDate));
            cryRpt.SetParameterValue("CaseType1", cmbCaseType1.SelectedItem.ToString());
            cryRpt.SetParameterValue("DoctorName", cmbDoctorName.SelectedItem.ToString());
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }

        private void OPCaseType1Report_Load(object sender, EventArgs e)
        {
            xDb.LoadComboBox1("select doctor_name,doctor_name from m_doctor", cmbDoctorName, "doctor_name", "doctor_name");
        }
    }
}
