using AirlineReservation.Application.Interface;
using AirlineReservation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Application.Services
{
    public class BookingService : IBookingService
    {   
        private readonly List<Flight> _flights;

        public BookingService()
        {
            _flights = new List<Flight>();
            InitializeFlight();
        }
        public async Task AddFlight(Flight flight)
        {
           _flights.Add(flight);
        }

        public async Task BookFlight(Flight bookflight, Passenger passenger, string seatNumber)
        {
            var ticket = new Ticket(Guid.NewGuid().ToString(), passenger, bookflight, seatNumber);
            bookflight.BookSeat(ticket);
            // assum payment has handle here
            Console.WriteLine($"Ticket booked successfully for{passenger.Name}. Payment processed");
        }
        /// <summary>
        /// cancel a ticket base on the ticket number
        /// </summary>
        /// <param name="ticketNumber"></param>
        /// <returns></returns>
        public async Task CancelBooking(string ticketNumber)
        {
            // loop through to find the ticket
            foreach (var flight in _flights)
            {
                var ticket = flight.Tickets.Find(findTicketBaseOnTheTicketNo=>findTicketBaseOnTheTicketNo.TicketNumber==ticketNumber);
                // if the ticket is not null remove the ticket
                if(ticket != null)
                {
                    flight.Tickets.Remove(ticket);
                    // then, increase back the remaining seat by 1
                    flight.RemainingSeat++;

                    // remove the ticket on that passenger from the particular flight
                    ticket.Passengers.Tickets.Remove(ticket);
                    //assum there's some sort of refund
                    Console.WriteLine($"Booking canceled for ticket{ticketNumber}, refund on processed.");
                    break;
                }
            }
        }

        public async Task<Flight> GetSingleFlight(string flightNumber)
        {
            // return the collection of flights
            return _flights.Where(x => x.FlightNumber==flightNumber).First();
        }

        public async Task InitializeFlight()
        {
            _flights.Add(new Flight("ABC123", "Tur", "NGX", new DateTime(2024, 03, 08, 02, 00, 00),
                new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));

            _flights.Add(new Flight("ABC398", "BRT", "CAI", new DateTime(2024, 08, 05, 02, 00, 00),
               new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));

            //_flights.Add(new Flight("ABC123", "Los", "Ton", new DateTime(2024, 08, 03, 02, 00, 00),
            //   new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));

            //_flights.Add(new Flight("ABC123", "Mad", "Ton", new DateTime(2024, 08, 03, 02, 00, 00),
            //   new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));

            //_flights.Add(new Flight("ABC123", "LHR", "Abba", new DateTime(2024, 08, 03, 02, 00, 00),
            //   new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));
            //_flights.Add(new Flight("ABC123", "", "NGX", new DateTime(2024, 08, 03, 02, 00, 00),
            //   new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));

            //_flights.Add(new Flight("ABC123", "DOH", "NYC", new DateTime(2024, 08, 03, 02, 00, 00),
            //   new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));

            //_flights.Add(new Flight("ABC123", "HKG", "GHA", new DateTime(2024, 08, 04, 02, 00, 00),
            //   new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));

            //_flights.Add(new Flight("ABC123", "ABV", "AKS", new DateTime(2024, 08, 03, 02, 00, 00),
            //   new DateTime(2024, 08, 20, 20, 45, 55), 3000, 1900000));
        }

        public async Task<List<Flight>> SearchFlights(string departure, string destination, DateTime date)
        {

            return _flights.FindAll(search => search
            .DepartureAirport==departure && search
            .DestinationAirport == destination && search
            .Take_Off.Date == date
            .Date);
        }
    }
}
