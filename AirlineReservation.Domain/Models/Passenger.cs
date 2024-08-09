using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Domain.Models
{
    public class Passenger
    {
        public string PassengerId { get; set; }=string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; }=string.Empty;
        public string Email { get; set; }= string.Empty;
        public List<Ticket>? Tickets { get; set; }

        public Passenger( string name, string phone_number, string email)
        {
            PassengerId = new Guid().ToString();
            Name = name;
            Phone = phone_number;
            Email = email;
            Tickets = new List<Ticket>();
        }

        public void GetPassengerDetails()
        {
            Console.WriteLine($"Passenger ID: {PassengerId}");
            Console.WriteLine($"Passenger Name: {Name}");
            Console.WriteLine($"Passenger Contact Number: {Phone}");
            Console.WriteLine($"Passenger Contact Email: {Email}");
        }
    }
}
