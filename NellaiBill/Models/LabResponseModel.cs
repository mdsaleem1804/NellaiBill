using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill.Models
{
    public class LabResponseModel
    {
        public int LabId { get; set; }
        public DateTime BillDate { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public double TotalAmount { get; set; }

    }
}
