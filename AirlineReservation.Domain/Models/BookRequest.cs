using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Domain.Models
{
    /// <summary>
    /// This class is going to use to Map the object from the React
    /// </summary>
    public class BookRequest
    {
        public string FlightNumber { get; set; } = string.Empty;
        public string Name { get; set; }=string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
