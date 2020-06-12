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
    public partial class LabPatientTestReport : Form
    {
        private int _xLabId;
        public LabPatientTestReport(int xLabId)
        {
            InitializeComponent();
            _xLabId = xLabId;
        }

        private void LabPatientTestReport_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            GlobalClass globalClass = new GlobalClass();
            string path = globalClass.GetReportPath() + "rptLabPatientTestReport.rpt";
            cryRpt.Load(path);
            cryRpt.SetParameterValue("LabId", _xLabId);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }
    }
}
