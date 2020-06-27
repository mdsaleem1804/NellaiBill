using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using NellaiBill.Common;
using NellaiBill.Models;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NellaiBill.Master
{
    public partial class frmItem : Form
    {
        DatabaseConnection xDb = new DatabaseConnection();
        int xCategoryId;
        int xGroupId;
        int xItemId;
        int xTaxNo;
        public frmItem()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ta-IN");
            xDb.LoadComboBox("select category_id,category_name from m_category", cmbCategory, "category_id", "category_name");
            //xDb.LoadComboBox("select unit_no,unit_name from m_unit", cmbUnit, "unit_no", "unit_name");
            //xDb.LoadComboBox("select tax_no,tax_name from m_tax", cmbGst, "tax_no", "tax_name");
            cmbGroup.Enabled = false;
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            cmbCategory.SelectedIndex = 1;
            cmbGroup.Select();
            cmbTax.SelectedIndex = 0;

            if(xDb.GetConfig().IS_M_ProductnameInTamil=="NO")
            {
                lblProductNameInTamil.Visible = false;
                txtProductNameInTamil.Visible = false;
            }
            if (xDb.GetConfig().IS_M_HsnCode == "NO")
            {
                lblHsnCode.Visible = false;
                txtHsnCode.Visible = false;
            }
            if (xDb.GetConfig().IS_M_ProductCode == "NO")
            {
                lblProductCode.Visible = false;
                txtProductCode.Visible = false;
            }
        }

        private void LoadGrid()
        {
            string xQuery = "select  " +
                " c.category_id,g.group_id,i.product_id," +
                " c.category_name as CATEGORY," +
                " g.group_name as GROUP_NAME," +
                " i.product_name as ProductName, " +
                " i.product_name_tamil as ProductNameInTamil, " +
                " i.product_code as ProductCode, " +
                 " i.hsn_code as hsn_code " +           
                " from m_category c,m_group g, " +
                " m_product i " +
                " where c.category_id = i.category_id " +
                " and g.group_id = i.group_id" +
                " order by g.group_name,i.product_name ";

            xDb.LoadGrid(xQuery, dataGridView1);
            dataGridView1.Columns["CATEGORY"].Width = 70;
            dataGridView1.Columns["GROUP_NAME"].Width = 70;

            mBtnSaveUpdate.Text = "SAVE";
        }

        private void DataClear()
        {
            txtProductName.Text = "";
            txtProductNameInTamil.Text = "";
            txtProductCode.Text = "";
            txtHsnCode.Text = "";
            mBtnSaveUpdate.Text = "SAVE";
            txtProductName.Focus();
        }


        public void DataProcess()
        {
            xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            xGroupId = Int32.Parse(cmbGroup.SelectedValue.ToString());
            //byte[] xTamil = UTF8Encoding.UTF8.GetBytes(txtProductNameInTamil.Text.ToString()); ;
            var xTamil = txtProductNameInTamil.Text;
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string xHsnCode = txtHsnCode.Text.ToString();
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please Enter  Name");
                txtProductName.Focus();
                return;
            }
            string xQry = "";
            if (mBtnSaveUpdate.Text == "SAVE")

            {
                        xItemId = xDb.GetMaxId("product_id", "m_product");
                        string xProductDetails = "";
                        xQry = "insert into   m_product" +
                            "(product_id,category_id,group_id,product_name,product_name_tamil,product_code,hsn_code,gst,created_by,created_on) " +
                            "values(" + xItemId + ","
                            + xCategoryId + ","
                            + xGroupId + ",'"
                            + txtProductName.Text + "','"
                            + txtProductNameInTamil.Text + "','"
                            + txtProductCode.Text + "','"
                            + xHsnCode + "','" + cmbTax.Text + "','" + xUser + "','" + xCurrentDateTime + "' )";

                          xDb.DataProcess(xQry);

                        MessageBox.Show("Item Added.");              
            }
            else
            {

                xQry = " update m_product " +
                    " set category_id=" + xCategoryId + ", " +
                    " group_id=" + xGroupId + ", " +
                    " product_name = '" + txtProductName.Text + "',  " +
                    " product_name_tamil = '" + xTamil + "',  " +
                    " product_code = '" + txtProductCode.Text + "',  " +
                    " hsn_code = '" + xHsnCode + "',  " +
                    " gst = '" + cmbTax.Text + "',  " +
                    " updated_by = '" + xUser + "',  " +
                    " updated_on = '" + xCurrentDateTime + "'  " +
                    " where  product_id= " + xItemId + "";
                xDb.DataProcess(xQry);

    
           

            }

            LoadGrid();
            DataClear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                xCategoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                xGroupId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                xItemId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmbCategory.SelectedIndex = cmbCategory.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                cmbGroup.SelectedIndex = cmbGroup.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                txtProductName.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtHsnCode.Text = dataGridView1.Rows[e.RowIndex].Cells["hsn_code"].Value.ToString();
                txtProductNameInTamil.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductNameInTamil"].Value.ToString();
                txtProductCode.Text = dataGridView1.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
                mBtnSaveUpdate.Text = "UPDATE";
            }
        }


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGroup.Enabled = true;
            xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            xDb.LoadComboBox("select group_id,group_name" +
                " from m_group where category_id=" + xCategoryId, cmbGroup, "group_id", "group_name");
        }

        private void mBtnCancel_Click(object sender, EventArgs e)
        {
            DataClear();
            LoadGrid();
        }

        private void mBtnSaveUpdate_Click(object sender, EventArgs e)
        {
          
            if (cmbCategory.Text == "" || cmbCategory.Text == "Please select")
            {
                MessageBox.Show("Please Choose an Category");
                return;
            }
            if (cmbGroup.Text == "" || cmbGroup.Text == "Please select")
            {
                MessageBox.Show("Please Choose an Category/Group");
                return;
            }
            if (txtProductName.Text == "")
            {
                MessageBox.Show("Please Choose an Item");
                txtProductName.Focus();
                return;
            }
           
            DataProcess();
        }

      

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "CATEGORY Like '%" + txtSearch.Text + "%' or GROUP_NAME Like '%" + txtSearch.Text + "%' or product_name Like '%" + txtSearch.Text + "%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format(xFilterSearch);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            exporttoexcel();

            //// creating Excel Application  
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //// creating new WorkBook within Excel application  
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //// creating new Excelsheet in workbook  
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //// see the excel sheet behind the program  
            //app.Visible = true;
            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            //// storing header part in Excel  
            //for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            //}
            //// storing Each row and column value to excel sheet  
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //    }
            //}
            //// save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //// Exit from the application  
            //app.Quit();



            //copyAlltoClipboard();
            //Microsoft.Office.Interop.Excel.Application xlexcel;
            //Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;
            //xlexcel = new Microsoft.Office.Interop.Excel.Application();
            //xlexcel.Visible = true;
            //xlWorkBook = xlexcel.Workbooks.Add(misValue);
            //xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            //CR.Select();
            //xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ExportToPdf()
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
                            PdfPTable pdfTable = new PdfPTable(5);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                if (!column.Visible) continue;

                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {


                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (!dataGridView1.Columns[cell.ColumnIndex].Visible) continue;
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
        }
        private void exporttoexcel()
        {

            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    // Bind Grid Data to Datatable
                    DataTable dt = new DataTable();
                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                    {
                        dt.Columns.Add(col.HeaderText, col.ValueType);
                    }
                    int count = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (count < dataGridView1.Rows.Count - 1)
                        {
                            dt.Rows.Add();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            }
                        }
                        count++;
                    }
                    // Bind table data to Stream Writer to export data to respective folder
                    StreamWriter wr = new StreamWriter(@"E:\\Book1.xls");
                    // Write Columns to excel file
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        wr.Write(dt.Columns[i].ToString().ToUpper() + "\t");
                    }
                    wr.WriteLine();
                    //write rows to excel file
                    for (int i = 0; i < (dt.Rows.Count); i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            if (dt.Rows[i][j] != null)
                            {
                                wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    }
                    wr.Close();
                    label1.Text = "Data Exported Successfully";
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportToPdf();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dataGridView1.AdvancedCellBorderStyle.Top;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;
            }
        }
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dataGridView1[column, row];
            DataGridViewCell cell2 = dataGridView1[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

      
        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            string xQry = "select * from m_product where product_code = '" + txtProductCode.Text + "'";
            ProductModel productModel = xDb.GetProductFromProductId(xQry);
            if (productModel.ProductCode == null)
            {

            }
            else
            {
                MessageBox.Show("Code Already Entered for " + productModel.ProductName);
            }
        }
    }
}

