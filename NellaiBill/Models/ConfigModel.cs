using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NellaiBill.Models
{
   public class ConfigModel
    {
       public int config_id { get; set; }
       public string is_hms { get; set; }
       public string is_accounts { get; set; }
       public string is_batch { get; set; }
       public string is_expiry { get; set; }
       public string backup_path { get; set; }
       public string is_m_hsn_code { get; set; }
       public string is_m_product_name_in_tamil { get; set; }
       public string is_m_product_code { get; set; }
       public string is_m_product_mrp { get; set; }
       public int doctor_id { get; set; }
       
    }
}

