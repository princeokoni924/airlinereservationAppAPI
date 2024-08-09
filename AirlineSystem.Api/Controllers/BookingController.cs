using AirlineReservation.Application.Interface;
using AirlineReservation.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace AirlineSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly ILogger<BookingController> _logger;
        private readonly IBookingService _booking;

        public BookingController(ILogger<BookingController> logger, IBookingService booking)
        {
            _logger=logger;
            _booking=booking;
        }
        /// <summary>
        /// search for flight
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="destination"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpGet("Search")]
        public async Task<IActionResult> SearchFlights(string departure, string destination, DateTime date)
        {
            var flights = await _booking.SearchFlights(departure, destination, date);
            return Ok(flights);
        }

        [HttpPost("book")]
        // set Authorization
        public async Task<IActionResult> BookFlight(BookRequest request)
        {
            var passenger = new Passenger( request.PhoneNumber, request.Email, request.Name);

            // get the flight base on the flight number
            var flight = await _booking.GetSingleFlight(request.FlightNumber);

            // user booking service
            await _booking.BookFlight(flight, passenger, "A1");
            return Ok("Flight booked successfully.");
        }

        [HttpDelete("cancel/{ticketNumber}")]
        public async Task<IActionResult> CancelBooking(string ticketNumber)
        {
            // cancel the ticket base on the ticket number
             await _booking.CancelBooking(ticketNumber);
            return Ok("Booking canceled successfully.");
        }
    }
}
