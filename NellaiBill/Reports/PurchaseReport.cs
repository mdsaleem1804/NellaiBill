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
    public partial class PurchaseReport : Form
    {
        ReportDocument cryRpt = new ReportDocument();
        DatabaseConnection xDb = new DatabaseConnection();
        GlobalClass globalClass = new GlobalClass();
        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
           // xDb.LoadComboBox("select account_ledger_id,ledger_name from account_ledger where ledger_undergroup_no=5", cmbSupplier, "account_ledger_id", "ledger_name");

        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            string xFromDate = dtpFromDate.Text;
            string xToDate = dtpToDate.Text;
            string path = globalClass.GetReportPath() + "rptPurchaseConsolidated.rpt";
            cryRpt.Load(path);
            cryRpt.SetParameterValue("FromDate", DateTime.Parse(xFromDate));
            cryRpt.SetParameterValue("ToDate", DateTime.Parse(xToDate));
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;


        }
    }
}
