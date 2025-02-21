namespace FlightBookingApi.Models
{
    public class Flight
    {
            public int Id { get; set; }
            public string Airline { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public DateTime DepartureTime { get; set; }
            public DateTime ArrivalTime { get; set; }
    }
}
