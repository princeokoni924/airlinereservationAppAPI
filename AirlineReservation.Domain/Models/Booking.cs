using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Domain.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Flight? FlightId { get; set; }
        public Passenger? PassengerId { get; set; }
        public string PaymentStatus { get; set; } = string.Empty;
    }
}
