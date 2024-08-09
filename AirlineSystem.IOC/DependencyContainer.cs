using AirlineReservation.Application.Interface;
using AirlineReservation.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AirlineSystem.IOC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection service)
        {
            service.AddSingleton<IBookingService, BookingService>();
        }
    }
}
