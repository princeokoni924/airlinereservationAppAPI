using AirLineReservation.Exceptions;
using AirLineReservation.Exceptions.Utilities;
using System.Globalization;

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

        
        private void ProcessPayment()
        {
            // implement payment api to proceed payment
        }


        private bool VerifyCardDetais()
        {
          if(string.IsNullOrWhiteSpace(CardNumber)|| CardNumber.Length<12|| CardNumber.Length<16|| CardNumber.Length<19)
          {
                return false;
                throw new ReservationEx("invalid cardNumber");
          }
            if (string.IsNullOrWhiteSpace(CardHolderName))
            {
                return false ;
                throw new ReservationEx("card holder name require");
            }

            DateTime cardExpiryDate;
            if (!DateTime.TryParseExact(CardExpiryDate,"MM/yy",null,DateTimeStyles.None, out cardExpiryDate))
            {
              return false;
            }else if (cardExpiryDate<DateTime.UtcNow)
            {
                return false;
            }
            else
            {
                return true;
            }
      
        }

        private bool CompletePayment()
        {
            return Status == "payment successfully completed";
        }
    }
}
