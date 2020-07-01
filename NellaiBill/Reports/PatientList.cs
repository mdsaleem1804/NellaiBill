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
    public partial class PatientList : Form
    {
        ReportDocument reportDocument = new ReportDocument();
        GlobalClass globalClass = new GlobalClass();
        public PatientList()
        {
            InitializeComponent();
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            string path = globalClass.GetReportPath() + "rptPatientList.rpt";
            reportDocument.Load(path);
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.ToolPanelView = ToolPanelViewType.None;
        }
    }
    }

