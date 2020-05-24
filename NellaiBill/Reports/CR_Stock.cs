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
    public partial class CR_Stock : Form
    {
        ReportDocument cryRpt = new ReportDocument();
        GlobalClass globalClass = new GlobalClass();
        public CR_Stock()
        {
            InitializeComponent();
        }

        private void CR_Stock_Load(object sender, EventArgs e)
        {
            string path = globalClass.GetReportPath() + "rptStock.rpt";
            cryRpt.Load(path);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }

}
