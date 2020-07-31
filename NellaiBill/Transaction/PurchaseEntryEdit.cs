using NellaiBill.Common;
using NellaiBill.Master;
using NellaiBill.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NellaiBill.Transaction
{
    public partial class PurchaseEntryEdit : Form
    {
        string xPurchaseId;
        DatabaseConnection xDb = new DatabaseConnection();
        public PurchaseEntryEdit(string purchaseId)
        {
            xPurchaseId = purchaseId;
           InitializeComponent();
        }

        private void btnLedgerSearch_Click(object sender, EventArgs e)
        {
            SearchSupplier search = new SearchSupplier(4);
            search.ShowDialog();
            if (search.xSupplierNo.ToString() != "0")
            {
                txtSupplierId.Text = search.xSupplierNo.ToString();
                txtName.Text = search.xSupplierName.ToString();
                txtMobileNo.Text = search.xSupplierMobileNo.ToString();
                rchAddress.Text = search.xSupplierAddress.ToString();
            }
        }

        private void PurchaseEntryEdit_Load(object sender, EventArgs e)
        {
            txtPurchaseId.Text = xPurchaseId;
            PurchaseModel purchaseModel = xDb.GetPurchaseFromPurchaseEntries("select * from purchase where purchase_id=" + xPurchaseId);
            dtpPEDate.Text = purchaseModel.PurchaseDate.ToString();
            SupplierModel supplierModel = xDb.GetSupplierFromSupplier("select * from m_supplier where supplier_id="+ purchaseModel.SupplierId);
            txtSupplierId.Text = supplierModel.SupplierId.ToString();
            txtName.Text = supplierModel.SupplierName;
            rchAddress.Text = supplierModel.SupplierAddress;
            txtMobileNo.Text = supplierModel.SupplierMobileNo;

        }

        private void btnUpdatePurchase_Click(object sender, EventArgs e)
        {
            string xUser = LoginInfo.UserID;
            string xCurrentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string   xQry = "update purchase set " +
                               " date = '" + dtpPEDate.Value.ToString("yyyy-MM-dd") + "',  " +
                                " supplier_id = '" + txtSupplierId.Text + "',  " +
                               " updated_by = '" + xUser + "',  " +
                               " updated_on = '" + xCurrentDateTime + "'  " +
                               " where  purchase_id= " +xPurchaseId + "";
            xDb.DataProcess(xQry);
            MessageBox.Show("Updated");

        }
    }
}
