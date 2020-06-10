using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models
{
    public class IpInvoiceDetailModel
    {
        public int TxNo { get; set; }
        public string Particulars { get; set; }
        public double Amount { get; set; }
    }
}
