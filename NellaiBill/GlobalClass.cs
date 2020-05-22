using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NellaiBill
{
    public class GlobalClass
    {

        public GlobalClass()
        {

        }
        public  string DoFormat(double myNumber)
        {
            return string.Format("{0:0.00}", myNumber);
        }
        
    }
}
