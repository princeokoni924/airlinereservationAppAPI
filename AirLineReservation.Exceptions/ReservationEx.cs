namespace AirLineReservation.Exceptions
{
    public class ReservationEx:ApplicationException
    {
        public ReservationEx(string error):base(error) { }
        public ReservationEx(string err, Exception innerEx):base(err, innerEx) { }  
        

    }
}
