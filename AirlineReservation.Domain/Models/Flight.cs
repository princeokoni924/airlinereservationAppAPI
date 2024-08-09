namespace AirlineReservation.Domain.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; } = string.Empty;
        public string DepartureAirport { get; set; } = string.Empty;
        public string DestinationAirport { get; set; } = string.Empty;
        public DateTime Take_Off { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Capacity { get; set; }
        public int RemainingSeat { get; set; }
        public decimal TicketPrice { get; set; }
        public List<Ticket> Tickets { get; set; }
        /// <summary>
        /// Flight custructor:
        /// This constructor will recieve all the property perimerter
        /// </summary>
        public Flight(string flightNumber,
            string departure,
            string destination,
            DateTime take_off,
            DateTime arrival,
            int capacity,
            decimal ticketPrice)
        {
            FlightNumber = flightNumber;
            DepartureAirport = departure;
            DestinationAirport = destination;
            Take_Off = take_off;
            ArrivalTime = arrival;
            Capacity = capacity;
            TicketPrice = ticketPrice;
            RemainingSeat = capacity;
            Tickets = new List<Ticket>();
        }

        public void GetFlightDetails()
        {
            Console.WriteLine($"Flight: {FlightNumber}");
            Console.WriteLine($"From: {DepartureAirport} To: {DestinationAirport}");
            Console.WriteLine($"Departure Time: {Take_Off}, Arrival Time: {ArrivalTime}");
            Console.WriteLine($"Remaining Seat: {RemainingSeat}/ {Capacity}");
            Console.WriteLine($"Ticket Price: ₦{TicketPrice}");
        }
         /// <summary>
         /// Available seat
         /// </summary>
         /// <returns>Remaining seat</returns>
        public int AvailableSeat()
        {
            return RemainingSeat;
        }

        public void BookSeat(Ticket ticket)
        {
            if (RemainingSeat>0)
            {
                Tickets.Add(ticket);
                RemainingSeat--;

                ticket.Passengers.Tickets.Add(ticket);
            }
            else
            {
                //if there's no remaining seat
                Console.WriteLine("No available seat on this flight");
            }
        }
    }
}
