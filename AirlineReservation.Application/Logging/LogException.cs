using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Application.Logging
{
    public class LogException:ApplicationException
    {
        public LogException(string err):base(err) 
        {
            
        }

        public LogException(string er, Exception innerEx):base(er, innerEx)
        {
            
        }
    }
}
