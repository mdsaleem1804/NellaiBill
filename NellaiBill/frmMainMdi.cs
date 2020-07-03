using MySql.Data;
using MySql.Data.MySqlClient;
using NellaiBill.Accounts;
using NellaiBill.Common;
using NellaiBill.Master;
using NellaiBill.Reports;
using NellaiBill.Transaction;
using NellaiBill.Transaction.IP;
using NellaiBill.Transaction.LAB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        DatabaseConnection xDb = new DatabaseConnection();
        string xUserName = LoginInfo.UserID;

        private void frm_main_mdi_Load(object sender, EventArgs e)
        {
            lblUserType.Text = xUserName;
            categoryToolStripMenuItem.Visible = false;
            if (xDb.GetConfig().IsHms == "NO")
            {
                patientRegistrationToolStripMenuItem.Visible = false;
                doctorRegistrationToolStripMenuItem.Visible = false;
                scanTestMasterToolStripMenuItem.Visible = false;
                ScanFeesMasterToolStripMenuItem.Visible = false;
                labFeesMasterToolStripMenuItem.Visible = false;
                caseTypeMasterToolStripMenuItem.Visible = false;
                roomMasterToolStripMenuItem.Visible = false;
                iPFeesMasterToolStripMenuItem.Visible = false;

                hmsTransactionMenu.Visible = false;
                oPSummaryReportToolStripMenuItem.Visible = false;
                scanSummaryToolStripMenuItem.Visible = false;
                labReportToolStripMenuItem.Visible = false;
                iPToolStripMenuItem.Visible = false;
                auditorDiagnosisSummaryReportToolStripMenuItem.Visible = false;
                ecgXraySummaryReportToolStripMenuItem.Visible = false;
                patientInformationReportToolStripMenuItem.Visible = false;
            }
           
            //Dashboard dashboard = new Dashboard();
            // dashboard.MdiParent = this;
            //dashboard.Show();
            
            CommonFormControls(new Payment());
        }
        private void GetAllMenus()
        {
            //Reference :https://stackoverflow.com/questions/15380730/foreach-every-subitem-in-a-menustrip
            List<ToolStripItem> allItems = new List<ToolStripItem>();
            foreach (ToolStripItem toolItem in menuStrip2.Items)
            {
                allItems.Add(toolItem);
                //add sub items
                allItems.AddRange(GetItems(toolItem));
            }
        }
        private IEnumerable<ToolStripItem> GetItems(ToolStripItem item)
        {
            if (item is ToolStripMenuItem)
            {
                foreach (ToolStripItem tsi in (item as ToolStripMenuItem).DropDownItems)
                {
                    if (tsi is ToolStripMenuItem)
                    {
                        if ((tsi as ToolStripMenuItem).HasDropDownItems)
                        {
                            foreach (ToolStripItem subItem in GetItems((tsi as ToolStripMenuItem)))
                                yield return subItem;
                        }
                        yield return (tsi as ToolStripMenuItem);
                    }
                    else if (tsi is ToolStripSeparator)
                    {
                        yield return (tsi as ToolStripSeparator);
                    }
                }
            }
            else if (item is ToolStripSeparator)
            {
                yield return (item as ToolStripSeparator);
            }
        }
        private void CommonFormControls(Form xForm)
        {
            if (this.MdiChildren.Length == 0) { }
            else
            {
                this.ActiveMdiChild.Close();
            }
            xForm.TopLevel = false;
            xForm.ControlBox = false;
            xForm.Dock = DockStyle.Fill;
           // xForm.BackColor = Color.Aqua;
            xForm.FormBorderStyle = FormBorderStyle.None;

            /*I assume this code is in your ParentForm and so 'this' points to ParentForm that contains ContainerPanel*/
            this.ContainerPanel.Controls.Add(xForm);
            xForm.WindowState = FormWindowState.Maximized;
            xForm.AutoScroll = true;
           // xForm.MdiParent = this;
            xForm.Show();
        }
        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new frmCompany());
        }
        private void patientRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonFormControls(new NewPatient());
        }

        private void doctorRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonFormControls(new DoctorRegistration());
        }

        private void groupToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CommonFormControls(new Group());
        }

        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CommonFormControls(new Category());
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new frmItem());
        }
        private void supplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new Supplier());
        }
        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CommonFormControls(new Customer());
        }

        private void userMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xUserName == "admin")
            {
                CommonFormControls(new UserMaster());
            }
            else
            {
                MessageBox.Show("Acces is denied");
                return;
            }

        }
        private void scanTestMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new ScanTestMaster());
        }

        private void caseTypeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new CaseTypeMaster());
        }

        private void roomMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new RoomMaster());
        }

        private void ScanFeesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new ScanFeesMaster());
        }
     
        private void iPFeesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new IPFeesMaster());
        }

        private void labFeesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new LabFeesMaster());
        }

        private void sCANBILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new ScanBilling());
        }
        private void lABBILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new LabBilling());
        }

        private void iPADMISSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new IPAdmission());
        }

        private void lABTESTENTRYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new LabTestEntry());
        }


        private void iPADVANCEPAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new IPPayment());
        }

        private void iPINVOICEBILLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new IPInvoice());
        }

        private void outPatientEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new OPBilling());
        }
        private void eCGBILLINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new EcgXrayBilling());
        }

        private void PurchaseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new PurchaseEntry());
        }



        private void PurchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new PurchaseReturn());
        }

        private void POSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new SalesEntry());
        }
        private void SalesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new SalesReturn());
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new frmSalesReport());
        }

        private void purchaseReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonFormControls(new PurchaseReport());
        }
        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new StockReport());
        }

        private void salesReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new SalesReturn());
        }
        private void patientInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new PatientList());
        }
        private void ecgXraySummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new EcgXraySummaryReport());
        }


        private void scanSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new ScanSummaryReport());
        }

        private void oPSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new OPSummaryReport());
        }
        private void auditorDiagnosisSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
         CommonFormControls(new DiagnosisDateWiseSummaryReport());  
        }
  
        private void iPConsolidatedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new IpInvoiceReport());
        }

        private void iPAdvanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new IPAdvanceReport());
        }

        private void iPAdmissionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new IPAdmissionReport());
        }

        private void labReportToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CommonFormControls(new LabSummaryReport());
        }
       
        private void iPDISCHARGESUMMARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new IPDischargeSummary());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CommonFormControls(new Backup());
        }

        

        private void stockAdjustmentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CommonFormControls(new StockAdjustment());
        }

        private void toolStripMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LogoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void stockDetailsBetweenDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new StockDetailBetweenDate());
        }
        private void calculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
        private void NotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void WordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad.exe");
        }

        private void MSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword.exe");
            
        }

        private void TaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void SystemInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new SystemInfo());
        }

        private void accountGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new AccountGroup());
        }

        private void receiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new Receipt());
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormControls(new Payment());
        }
    }
}
                               