using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models
{
    public class IpInvoiceModel
    {
        public int IpInvoiceId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int IpNo { get; set; }
        public double Amount { get; set; }
        public List<IpInvoiceDetailModel> IpInvoiceDetail { get; set; }
  
    }
}
