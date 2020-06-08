using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models
{
   public  class IPDetailModel
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }

        public int RoomId { get; set; }
    }
}

