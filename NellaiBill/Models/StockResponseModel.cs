using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models
{
    public class StockResponseModel
    {
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public double Mrp { get; set; }
        public string Batch { get; set; }
        public DateTime ExpDate { get; set; }

    }
}
