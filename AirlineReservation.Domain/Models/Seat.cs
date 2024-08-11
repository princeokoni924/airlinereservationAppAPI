using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Domain.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string SeatNumber { get; set; } = string.Empty;
        public string ClassType { get; set; } = string.Empty;
        public bool IsWindowSeat { get; set; }
        public bool IsOccupied { get; set; }
        public int AvailableSeat { get; set; }
        public string PassengerId { get; set; } = string.Empty;
        public string Amenities { get; set; } = string.Empty;
        public List<Ticket>? Tickets { get; set; }
        public string Message { get; set; } = string.Empty;

        public Passenger? Passengers { get; set; }
        public Seat()
        {
            PassengerId = new Guid().ToString().TrimEnd();
        }
    }
}
