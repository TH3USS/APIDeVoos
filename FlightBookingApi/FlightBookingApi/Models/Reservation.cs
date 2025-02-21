namespace FlightBookingApi.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FlightId { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
