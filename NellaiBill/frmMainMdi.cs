using MySql.Data;
using MySql.Data.MySqlClient;
using NellaiBill.Common;
using NellaiBill.Master;
using NellaiBill.Reports;
using NellaiBill.Transaction;
using NellaiBill.Transaction.IP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill
{
    public partial class frm_main_mdi : Form
    {
        public frm_main_mdi()
        {
            InitializeComponent();
        }
        GlobalClass globalClass = new GlobalClass();
        string xUserName = LoginInfo.UserID;

        private void frm_main_mdi_Load(object sender, EventArgs e)
        {
            lblUserType.Text = xUserName;         
            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = this;
            dashboard.Show();
        }
        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroup g = new frmGroup();
            g.MdiParent = this;
            g.Show();
        }

        private void salemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesEntry s = new SalesEntry();
            s.MdiParent = this;
            s.Show();
        }


        private void yearEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearEnd yearEnd = new YearEnd();
            yearEnd.MdiParent = this;
            yearEnd.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory category = new frmCategory();
            category.MdiParent = this;
            category.Show();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmItem item = new frmItem();
            item.MdiParent = this;
            item.Show();
        }



        private void setPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPrice setPrice = new SetPrice();
            setPrice.MdiParent = this;
            setPrice.Show();
        }



        private void dateWiseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.MdiParent = this;
            report.Show();
        }

        private void updateTestDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabBilling labEntry = new LabBilling();
            labEntry.MdiParent = this;
            labEntry.Show();
        }

        private void labReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabReport labReport = new LabReport();
            labReport.MdiParent = this;
            labReport.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.MdiParent = this;
            employee.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPatient employee = new NewPatient();
            employee.MdiParent = this;
            employee.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesEntry s = new SalesEntry();
            s.MdiParent = this;
            s.Show();
        }

        private void setPriceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetPrice setPrice = new SetPrice();
            setPrice.MdiParent = this;
            setPrice.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword();
            frmChangePassword.MdiParent = this;
            frmChangePassword.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }



        private void groupToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmGroup frmGroup = new frmGroup();
            frmGroup.MdiParent = this;
            frmGroup.Show();

        }

        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.MdiParent = this;
            frmCategory.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem frmItem = new frmItem();
            frmItem.MdiParent = this;
            frmItem.Show();
        }

        private void taxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTax frmTax = new frmTax();
            frmTax.MdiParent = this;
            frmTax.Show();
        }

        private void POSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesEntry salesEntry = new SalesEntry();
            salesEntry.MdiParent = this;
            salesEntry.Show();
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.MdiParent = this;
            backup.Show();
        }


        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CR_Stock report = new CR_Stock();
            report.MdiParent = this;
            report.Show();
        }

        private void PurchaseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseEntry purchaseEntry = new PurchaseEntry();
            purchaseEntry.MdiParent = this;
            purchaseEntry.Show();
        }

        private void stockAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPrice setPrice = new SetPrice();
            setPrice.MdiParent = this;
            setPrice.Show();
        }

        private void supplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger("Supplier");
            ledger.MdiParent = this;
            ledger.Show();
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger("Customer");
            ledger.MdiParent = this;
            ledger.Show();
        }

        private void stockHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockHistory frmStockHistory = new frmStockHistory();
            frmStockHistory.MdiParent = this;
            frmStockHistory.Show();
        }

        private void PurchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseReturn frmPurchaseReturn = new frmPurchaseReturn();
            frmPurchaseReturn.MdiParent = this;
            frmPurchaseReturn.Show();
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
            frmCompany.MdiParent = this;
            frmCompany.Show();
        }

        private void SalesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReturn frmSalesReturn = new frmSalesReturn();
            frmSalesReturn.MdiParent = this;
            frmSalesReturn.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SalesReportDG frmSalesReport = new SalesReportDG();
            //frmSalesReport.MdiParent = this;
            //frmSalesReport.Show();
            frmSalesReport frmSalesReport = new frmSalesReport();
            frmSalesReport.MdiParent = this;
            frmSalesReport.Show();
        }

        private void oldProjectReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebReports webReports = new WebReports();
            webReports.MdiParent = this;
            webReports.Show();
        }

        private void purchaseReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PurchaseReport frmPurchaseReport = new PurchaseReport();
            frmPurchaseReport.MdiParent = this;
            frmPurchaseReport.Show();
        }

        private void stockReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StockReport stockReport = new StockReport();
            stockReport.MdiParent = this;
            stockReport.Show();

        }

        private void salesReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CR_SalesReturn report = new CR_SalesReturn();
            // SalesReportDG report = new SalesReportDG();
            report.MdiParent = this;
            report.Show();
        }

        private void patientRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewPatient master = new NewPatient();
            master.MdiParent = this;
            master.Show();
        }

        private void doctorRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoctorRegistration master = new DoctorRegistration();
            master.MdiParent = this;
            master.Show();
        }

        private void oPTodaysCollectionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPSummaryReport report = new OPSummaryReport();
            report.MdiParent = this;
            report.Show();
        }


        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xUserName == "admin")
            {
                UserMaster master = new UserMaster();
                master.MdiParent = this;
                master.Show();
            }
            else
            {
                MessageBox.Show("Acces is denied");
                return;
            }
        
        }


        private void outPatientEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPBilling transaction = new OPBilling();
            transaction.MdiParent = this;
            transaction.Show();
        }
        private void eCGBILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcgXrayBilling transaction = new EcgXrayBilling();
            transaction.MdiParent = this;
            transaction.Show();
        }

        private void ecgXraySummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcgXraySummaryReport report = new EcgXraySummaryReport();
            report.MdiParent = this;
            report.Show();
        }

        private void scanTestMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanTestMaster master = new ScanTestMaster();
            master.MdiParent = this;
            master.Show();
        }

        private void ScanFeesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanFeesMaster master = new ScanFeesMaster();
            master.MdiParent = this;
            master.Show();
        }

        private void sCANBILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanBilling master = new ScanBilling();
            master.MdiParent = this;
            master.Show();
        }

        private void scanSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanSummaryReport report = new ScanSummaryReport();
            report.MdiParent = this;
            report.Show();
        }

        private void oPSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPSummaryReport report = new OPSummaryReport();
            report.MdiParent = this;
            report.Show();
        }

        private void lABBILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabBilling billing = new LabBilling();
            billing.MdiParent = this;
            billing.Show();
        }

        private void iPADMISSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPAdmission billing = new IPAdmission();
            billing.MdiParent = this;
            billing.Show();
        }

        private void auditorDiagnosisSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (xUserName == "admin")
            {
                DiagnosisDateWiseSummaryReport report = new DiagnosisDateWiseSummaryReport();
                report.MdiParent = this;
                report.Show();
            }
            else
            {
                MessageBox.Show("Sorry !!! Please contact Admin");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void iPADVANCEPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPPayment billing = new IPPayment();
            billing.MdiParent = this;
            billing.Show();
        }

        private void iPINVOICEBILLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPInvoice billing = new IPInvoice();
            billing.MdiParent = this;
            billing.Show();
        }
        private void iPConsolidatedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IpInvoiceReport report = new IpInvoiceReport();
            report.MdiParent = this;
            report.Show();
        }

        private void iPAdvanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPAdvanceReport report = new IPAdvanceReport();
            report.MdiParent = this;
            report.Show();
        }

        private void iPAdmissionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPAdmissionReport report = new IPAdmissionReport();
            report.MdiParent = this;
            report.Show();
        }

        private void caseTypeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaseTypeMaster master = new CaseTypeMaster();
            master.MdiParent = this;
            master.Show();
        }

        private void roomMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomMaster master = new RoomMaster();
            master.MdiParent = this;
            master.Show();
        }

        private void labReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LabSummaryReport report = new LabSummaryReport();
            report.MdiParent = this;
            report.Show();
        }
    }   
}
