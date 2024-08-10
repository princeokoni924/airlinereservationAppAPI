﻿using AirlineReservation.Domain.Models;

namespace AirlineReservation.Application.Interface
{
    public interface IBookingService
    {
        /// <summary>
        /// Add flight
        /// </summary>
        /// <param name="flight">flight</param>
        /// <returns></returns>
        Task AddFlight(Flight flight);


        /// <summary>
        /// Search Flight
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="destination"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task <List<Flight>> SearchFlights(string departure, string destination, DateTime date);

        /// <summary>
        /// get single flight
        /// </summary>
        /// <param name="flightNumber"></param>
        /// <returns></returns>
        Task<Flight> GetSingleFlight(string flightNumber);

        Task BookFlight(Flight bookflight, Passenger passenger, string seatNumber);

        Task CancelBooking(string ticketNumber);

        Task InitializeFlight();

        Task Proc
    }
}
