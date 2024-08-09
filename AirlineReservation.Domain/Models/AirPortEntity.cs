using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Domain.Models
{
    public class AirPortEntity
    {
        public int Id { get; set; }
        public string AirportCode { get; set; }=string.Empty;
        public string AirportName { get; set; }=string.Empty;
        public string Location { get; set; }=string.Empty;
        public string Facilities { get; set; }=string.Empty;
    }
}
