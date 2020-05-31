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
    public partial class OutPatientReport : Form
    {
        ReportDocument cryRpt = new ReportDocument();
        GlobalClass globalClass = new GlobalClass();
        public OutPatientReport()
        {
            InitializeComponent();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            string xFromDate = dtpFromDate.Text;
            string xToDate = dtpToDate.Text;
            string path = globalClass.GetReportPath() + "rptOPConsolidated.rpt";
            cryRpt.Load(path);

            //cryRpt.SetParameterValue("FromDate", DateTime.Parse(xFromDate));
            //cryRpt.SetParameterValue("ToDate", DateTime.Parse(xToDate));
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }
    }
}
