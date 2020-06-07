using CrystalDecisions.CrystalReports.Engine;
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
    public partial class DiagnosisDateWiseSummaryReport : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        ReportDocument cryRpt = new ReportDocument();
        GlobalClass globalClass = new GlobalClass();
        public DiagnosisDateWiseSummaryReport()
        {
            InitializeComponent();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            string xFromDate = dtpFromDate.Text;
            string xToDate = dtpToDate.Text;
            string path = globalClass.GetReportPath() + "rptDiagnosisConsolidated.rpt";
            cryRpt.Load(path);

            cryRpt.SetParameterValue("FromDate", DateTime.Parse(xFromDate));
            cryRpt.SetParameterValue("ToDate", DateTime.Parse(xToDate));
            cryRpt.SetParameterValue("DiagnosisType", cmbDiagnosis.Text);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void DiagnosisDateWiseSummaryReport_Load(object sender, EventArgs e)
        {
            cmbDiagnosis.SelectedIndex = 0;
        }
    }
}
