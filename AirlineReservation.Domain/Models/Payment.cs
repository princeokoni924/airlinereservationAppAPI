using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservation.Domain.Models
{
    public class Payment
    {
        public int Id{ get; set; }
        public string PaymentId { get; set; } = string.Empty;
        public string BookingId { get; set; } = string.Empty;
        public string PaymentMethod { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public BookRequest? Bookings { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string CardExpiryDate { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public void ProcessPayment()
        {
            // implement payment api
        }


        public bool VerifyCardDetais()
        {
          if(string.IsNullOrWhiteSpace(CardNumber)|| CardNumber.Length<12|| CardNumber.Length<16|| CardNumber.Length<19)
                
                return false;
        }
    }
}
