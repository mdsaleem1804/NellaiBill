using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models
{
    public class ConfigResponseModel
    {
        public string BackUpPath { get; set; }
        public string IsHms { get; set; }
        public string IsBatch { get; set; }
        public string IsExpiry { get; set; }
        public string IS_M_ProductnameInTamil { get; set; }
        public string IS_M_HsnCode { get; set; }

        public string IS_M_ProductCode { get; set; }
    }
}
