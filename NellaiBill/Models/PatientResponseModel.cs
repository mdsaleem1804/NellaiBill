using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models
{
   public class PatientResponseModel
    {
        public int PatientId { get; set; }
        public string UHID { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }
        public string PatientMobileNo { get; set; }
    }
}
