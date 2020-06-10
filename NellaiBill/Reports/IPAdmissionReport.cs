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
    public partial class IPAdmissionReport : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        ReportDocument cryRpt = new ReportDocument();
        GlobalClass globalClass = new GlobalClass();
        public IPAdmissionReport()
        {
            InitializeComponent();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {

            string xFromDate = dtpFromDate.Text;
            string xToDate = dtpToDate.Text;
            string path = globalClass.GetReportPath() + "rptIpAdmissionReport.rpt";
            cryRpt.Load(path);

            cryRpt.SetParameterValue("FromDate", DateTime.Parse(xFromDate));
            cryRpt.SetParameterValue("ToDate", DateTime.Parse(xToDate));
            //if (chkSelectAllIpNo.Checked)
            //{
            //    cryRpt.SetParameterValue("ipno", 0);
            //}
            //else
            //{
            //    cryRpt.SetParameterValue("DoctorName", cmbIPNo.Text);
            //}
            cryRpt.SetParameterValue("DoctorName", cmbDoctor.Text);
           // cryRpt.SetParameterValue("CaseType", cmbCaseType.Text);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }

        private void IPConsolidatedReport_Load(object sender, EventArgs e)
        {
            //  xDb.LoadComboBoxForReport("select ecg_xray_test_fees_id,test_name from m_ecg_xray_test_fees", cmbCaseType, "ecg_xray_test_fees_id", "test_name");
            xDb.LoadComboBoxForReport("select doctor_id,doctor_name from m_doctor", cmbDoctor, "doctor_id", "doctor_name");

        }
    }
}
