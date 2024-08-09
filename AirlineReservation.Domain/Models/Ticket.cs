namespace AirlineReservation.Domain.Models
{
    public class Ticket
    {
        public string TicketNumber { get; set; } = string.Empty;
        public Passenger Passengers { get; set; }
        public Flight Flights { get; set; }
        public string SeatNumber { get; set; } = string.Empty;
        
        public Ticket(string ticketNumber, Passenger passenger, Flight flight, string seatNumber)
        {
            TicketNumber = ticketNumber;
            Passengers = passenger;
            Flights = flight;
            SeatNumber = seatNumber;
        }

        public void GetTicketDetails()
        {
            Console.WriteLine($"Ticket Number:{TicketNumber}");
            Console.WriteLine($"Passenger:{Passengers.Name}");
            Console.WriteLine($"Flight:{Flights.FlightNumber}");
            Console.WriteLine($"Seat Number: {SeatNumber}");
        }
    }
}