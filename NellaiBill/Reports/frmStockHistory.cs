using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Windows.Forms;

namespace NellaiBill.Reports
{
    public partial class frmStockHistory : Form
    {
        ReportDocument cryRpt = new ReportDocument();
        DatabaseConnection xDb = new DatabaseConnection();
        public frmStockHistory()
        {
            InitializeComponent();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            
           // crystalReportViewer1.RefreshReport();
            string xFromDate = dtpFromDate.Text;
            string xToDate = dtpToDate.Text;
            //string path = xDb.xReportPath + "rptStockHistory.rpt";
            string path = System.Windows.Forms.Application.StartupPath + "\\CrystalReports\\rptStockHistory.rpt";
            cryRpt.Load(path);
            if (mChkSelectAllItem.Checked)
            {
                cryRpt.SetParameterValue("product_id", 0);
            }

            else
            {

                cryRpt.SetParameterValue("product_id", cmbItem.SelectedValue);
            }
            // cryRpt.SetParameterValue("ToDate", DateTime.Parse(xToDate));
          //  crystalReportViewer1.ReportSource = cryRpt;
            
        }

        private void frmStockHistory_Load(object sender, EventArgs e)
        {

          xDb.LoadComboBox("select product_id,product_name from m_product", cmbItem, "product_id", "product_name");
        }

       
    }
    }

