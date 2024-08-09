using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Domain.Models
{
    public class AirlineEntity
    {
        public int Id { get; set; }
        public string Airline_Name { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Airline_ContactNo { get; set; } = string.Empty;

        public AirlineEntity(string airlineName, string region, string airlineContactNo)
        {
            Airline_Name = airlineName;
            Region = region;
            Airline_ContactNo = airlineContactNo;
        }


        public void GetAirlineDetail()
        {
            Console.WriteLine($"Airline Name{Airline_Name}");
            Console.WriteLine($"Region {Region}");
            Console.WriteLine($"Contact Number {Airline_ContactNo}");
        }
    }
}
