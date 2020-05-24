using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
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
            xDb.LoadComboBox("select itemcategoryno,itemcategoryname from m_itemcategory", cmbCategory, "itemcategoryno", "itemcategoryname");
            //xDb.LoadComboBox("select unit_no,unit_name from m_unit", cmbUnit, "unit_no", "unit_name");
            //xDb.LoadComboBox("select tax_no,tax_name from m_tax", cmbGst, "tax_no", "tax_name");
            cmbGroup.Enabled = false;
            mBtnDelete.Enabled = false;
            LoadGrid();
            DataClear();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
            cmbCategory.Select();
        }

        private void LoadGrid()
        {
            string xQuery = "select  " +
                " c.itemcategoryno,g.itemgroupno,i.itemno," +
                " c.itemcategoryname as CATEGORY," +
                " g.itemgroupname as GROUP_NAME," +
                " i.itemname as ITEMNAME, " +
                 " i.hsncode as HSNCODE, " +
                 " i.gst as TAX," +
                //" t.tax_name as TAX," +
                " i.packdescription as UNIT" +
                " from m_itemcategory c,m_itemgroup g, " +
                " m_item i " +
                // ", m_tax t" +
                " where c.itemcategoryno = i.itemcategoryno " +
                //" and t.tax_no = i.gst " +
                " and g.itemgroupno = i.itemgroupno" +
                " ";

            xDb.LoadGrid(xQuery, dataGridView1);

            mBtnSaveUpdate.Text = "SAVE";
        }

        private void DataClear()
        {
            txtItemName.Text = "";
            txtOpeningStock.Text = "0";
            txtPrice.Text = "0";
            mBtnSaveUpdate.Text = "SAVE";
            mBtnDelete.Enabled = false;
            txtItemName.Focus();
        }


        public void DataProcess()
        {
            xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            xGroupId = Int32.Parse(cmbGroup.SelectedValue.ToString());
            //xUnitNo = Int32.Parse(cmbUnit.SelectedValue.ToString());
            xTaxNo = Int32.Parse(cmbGst.SelectedItem.ToString());
            double xPrice = double.Parse(txtPrice.Text.ToString());
            string xHsnCode = txtHsnCode.Text.ToString();
            string xOpeningStockExpDate = Convert.ToDateTime(dtpExpDate.Text).ToString("yyyy-MM-dd");
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Please Enter  Name");
                txtItemName.Focus();
                return;
            }
            string xQry = "";
            if (mBtnSaveUpdate.Text == "SAVE")
            {
                if (txtOpeningStock.Text == "")
                {
                    MessageBox.Show("It Should not be Empty/Atleast Zero");
                    txtOpeningStock.Focus();
                    return;
                }
                using (MySqlConnection myConnection = new MySqlConnection(xDb.conString))
                {
                    myConnection.Open();
                    MySqlTransaction myTrans = myConnection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                    MySqlCommand myCommand = myConnection.CreateCommand();
                    try
                    {
                        xItemId = xDb.GetMaxId("itemno", "m_item");


                        int xStockPointNo = 1;
                        xQry = "insert into   m_item" +
                            "(itemno,stockpointno,itemcategoryno,itemgroupno,itemname,hsncode,gst,packdescription,mrp) " +
                            "values(" + xItemId + ","
                            + xStockPointNo + ","
                            + xCategoryId + ","
                            + xGroupId + ",'"
                            + txtItemName.Text + "','"
                            + xHsnCode + "',"
                            + xTaxNo + ",'',"
                            + xPrice + ")";
                        int xOpeningStock = Convert.ToInt32(txtOpeningStock.Text.ToString());
                        int xStockId = xDb.GetMaxId("stockno", "inv_stockentry");
                        string xBatch = "OS";
                        string xQryStockEntry = "insert into   inv_stockentry" +
                            " (stockno,itemno,stock,mrp,batch,expdate) " +
                            " values(" + xStockId + "," + xItemId + "," + xOpeningStock + "," + xPrice + ",'" + xBatch + "','" + xOpeningStockExpDate + "')";
                        //int xStockHistoryId = xDb.GetMaxId("stock_history_id", "stock_history");
                        //string xQryStockDetails = "insert into   stock_history" +
                        //    " (stock_history_id,itemno,category,qty,remarks)" +
                        //    "  values(" + xStockHistoryId + "," + xItemId + ",'ITEM'," + xOpeningStock + ",'NEW ITEM CREATED')";

                        string xQryStockDetails = "insert into audit_stock" +
                  " (audit_stock_itemno,audit_stock_qty," +
                  " audit_stock_mrp,audit_stock_batch," +
                  " audit_stock_datetime,audit_stock_mode)" +
                  " values(" + xItemId
                  + "," + xOpeningStock
                  + "," + 0
                  + ",'" + xBatch
                  + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                  + "','NEW ITEM')";

                        myCommand.CommandText = xQry;
                        myCommand.ExecuteNonQuery();
                        myCommand.CommandText = xQryStockEntry;
                        myCommand.ExecuteNonQuery();
                        myCommand.CommandText = xQryStockDetails;
                        myCommand.ExecuteNonQuery();

                        myTrans.Commit();
                        MessageBox.Show("Item Added.");

                    }
                    catch (Exception ex)
                    {
                        myTrans.Rollback();
                        MessageBox.Show("Some Error - Item Not Added." + ex.ToString());
                    }
                    finally
                    {
                        myCommand.Dispose();
                        myTrans.Dispose();
                        myConnection.Close();
                    }
                }
            }
            else
            {

                xQry = " update m_item " +
                    " set itemcategoryno=" + xCategoryId + ", " +
                    " itemgroupno=" + xGroupId + ", " +
                    " itemname = '" + txtItemName.Text + "',  " +
                    " hsncode = '" + xHsnCode + "',  " +
                    " mrp = " + txtPrice.Text + ",  " +
                    " gst = " + xTaxNo + ",  " +
                    " packno = " + 1 + " , " +
                    " packdescription = '" + cmbUnit.Text + "'  " +
                    " where  itemno= " + xItemId + "";
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
                txtItemName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtHsnCode.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbGst.SelectedIndex = cmbGst.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                cmbUnit.SelectedIndex = cmbUnit.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                panelOpeningStock.Enabled = false;
                mBtnSaveUpdate.Text = "UPDATE";
                mBtnDelete.Enabled = true;
                txtOpeningStock.Enabled = false;
            }
        }


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGroup.Enabled = true;
            xCategoryId = Int32.Parse(cmbCategory.SelectedValue.ToString());
            xDb.LoadComboBox("select itemgroupno,itemgroupname" +
                " from m_itemgroup where itemcategoryno=" + xCategoryId, cmbGroup, "itemgroupno", "itemgroupname");
        }

        private void txtDiscValue_Leave(object sender, EventArgs e)
        {

            if (txtDiscValue.Text == "")
            {
                txtDiscValue.Text = "0";
            }
            else
            {
                double xTotalAmount = Convert.ToDouble(txtPrice.Text);
                double xDisValue = Convert.ToDouble(txtDiscValue.Text);
                double xPercentage = (xTotalAmount * xDisValue) / 100;
                txtDiscPercentage.Text = xPercentage.ToString();
            }
        }

        private void txtDiscPercentage_Leave(object sender, EventArgs e)
        {
            if (txtDiscPercentage.Text == "")
            {
                txtDiscPercentage.Text = "0";
            }
            else
            {
                double xTotalAmount = Convert.ToDouble(txtPrice.Text);
                double xPercentage = Convert.ToDouble(txtDiscPercentage.Text);
                double xDisValue = (xTotalAmount * xPercentage) / 100;
                txtDiscValue.Text = xDisValue.ToString();
            }
        }

        private void mBtnCancel_Click(object sender, EventArgs e)
        {
            DataClear();
            LoadGrid();
        }

        private void mBtnSaveUpdate_Click(object sender, EventArgs e)
        {
            //if (xDb.GetMaxId("itemno", "m_item")>50)
            //{
            //    MessageBox.Show("Please Check your software administrator- It's Expired");
            //    return;
            //}
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
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Please Choose an Item");
                txtItemName.Focus();
                return;
            }
            if (cmbGst.Text == "" || cmbGst.Text == "Please select")
            {
                MessageBox.Show("Please Choose an Gst");
                return;
            }

            if (cmbUnit.Text == "" || cmbUnit.Text == "Please select")
            {
                MessageBox.Show("Please Choose an Unit");
                return;
            }

            if (txtOpeningStock.Text == "")
            {
                MessageBox.Show("OpeningStock Should not be Empty/Atleast Zero");
                txtOpeningStock.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Price Should not be Empty/Atleast Zero");
                txtPrice.Focus();
                return;
            }
            DataProcess();
        }

        private void mBtnDelete_Click(object sender, EventArgs e)
        {

            int xCount = xDb.GetTotalCount("select * from inv_purchaseentry where itemno = " + xItemId + "");
            if (xCount >= 1)
            {
                MessageBox.Show("Sorry You can't delete this item - Purchae/Sales made");
                LoadGrid();
                DataClear();
                return;
            }
            else
            {
                xDb.DataProcess("delete from m_item where  itemno= " + xItemId + "");
            }

            LoadGrid();
            DataClear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string xFilterSearch = "CATEGORY Like '%" + txtSearch.Text + "%' or GROUP_NAME Like '%" + txtSearch.Text + "%' or ITEMNAME Like '%" + txtSearch.Text + "%'";
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
    }
}

