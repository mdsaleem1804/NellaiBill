using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Reports
{
    public partial class PurchaseSummaryReport : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        public PurchaseSummaryReport()
        {
            InitializeComponent();
        }

        private void PurchaseSummaryReport_Load(object sender, EventArgs e)
        {
            LoadComboBox();

            cmbLedger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbLedger.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbLedger.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadComboBox()
        {
            xDb.LoadComboBox("select account_ledger_id,ledger_name from account_ledger where ledger_undergroup_no=4", cmbLedger, "account_ledger_id", "ledger_name");

        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
       
        private void LoadGrid()
        {
            dataGridView1.ReadOnly = true;
            string xFilter = "";
            if (mChkSelectAllItem.Checked)
            {

            }
            else
            {
                string xLedgerId = cmbLedger.SelectedValue.ToString();
                xFilter += " and p.supplierno=" + xLedgerId;
            }

          
            string xQuery = "SELECT p.purchase_id as INVNO,p.date as DATE,l.ledger_name as SUPPLIERNAME," +
                "p.companyinvoiceno as COMPANYINVNO,p.totalamount as AMOUNT " +
                "from purchase p ,account_ledger l where l.account_ledger_id=p.supplierno " +
                " and date>='" + dtpFromDate.Text + "' and date <= '" + dtpToDate.Text + "' " + xFilter + " order by p.purchase_id desc";

            xDb.LoadGrid(xQuery, dataGridView1);
            dataGridView1.Columns["SUPPLIERNAME"].Width = 200;
            dataGridView1.Columns["DATE"].Width = 100;
            dataGridView1.Columns["INVNO"].Width = 100;
            dataGridView1.Columns["DATE"].DefaultCellStyle.Format = "dd /MMMM/yyyy";
            dataGridView1.Columns["INVNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["COMPANYINVNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["AMOUNT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                   }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //ExportPDF();
            CreatePDF();
        }
        private void CreatePDF()
        {
            string fileName = string.Empty;
            DateTime fileCreationDatetime = DateTime.Now;
            fileName = string.Format("{0}.pdf", fileCreationDatetime.ToString(@"yyyyMMdd") + "_" + fileCreationDatetime.ToString(@"HHmmss"));
            string pdfPath = "d:\\Test.pdf";

            using (FileStream msReport = new FileStream(pdfPath, FileMode.Create))
            {
                //step 1
                using (Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 140f, 10f))
                {
                    try
                    {
                        // step 2
                        PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, msReport);
                        pdfWriter.PageEvent = new ITextEvents();

                        //open the stream 
                        pdfDoc.Open();

                        //for (int i = 0; i < 10; i++)
                        //{
                        //    Paragraph para = new Paragraph("Hello world. Checking Header Footer");
                        //    para.Alignment = Element.ALIGN_CENTER;
                        //    pdfDoc.Add(para);
                        //    pdfDoc.NewPage();
                        //}
                        PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                   
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }
                        pdfDoc.Add(pdfTable);

                        pdfDoc.Close();
                    }
                    catch (Exception ex)
                    {
                        //handle exception
                    }
                    finally
                    {
                    }
                }
            }
        }
        private void ExportPDF()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            PdfPCell xWelcomeCell = new PdfPCell(new Phrase("WELCOME"));
                            pdfTable.AddCell(xWelcomeCell);
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
            //Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            //PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("d:\\Test.pdf", FileMode.Create));
            //doc.Open();//Open Document to write
            //Paragraph paragraph = new Paragraph("data Exported From DataGridview!");
            ////Create table by setting table value
            //Table t1 = new Table(2);
            //DataTable dt = (DataTable)dataGridView1.DataSource;
            ////Create Table Header
            //Cell cid = new Cell("ID");
            //Cell cname = new Cell("Name");
            //t1.AddCell(cid);
            //t1.AddCell(cname);
            //foreach (DataGridViewRow rows in dataGridView1.Rows)
            //{
            //    string id = dataGridView1.Rows[rows.Index].Cells["empid"].Value.ToString();
            //    string name = dataGridView1.Rows[rows.Index].Cells["ename"].Value.ToString();
            //    //Create Cells
            //    Cell c2 = new Cell(id);
            //    Cell c1 = new Cell(name);
            //    //Adding cells
            //    t1.AddCell(c1);
            //    t1.AddCell(c2);
            //}
            //doc.Add(paragraph);
            //doc.Add(t1);
            //doc.Close(); //Close document
            //             //
            //MessageBox.Show("PDF Created!");
        }
    }
}
