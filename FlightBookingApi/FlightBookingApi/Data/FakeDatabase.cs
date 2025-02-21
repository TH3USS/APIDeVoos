using FlightBookingApi.Models;

namespace FlightBookingApi.Data
{
    public class FakeDatabase
    {
        //Simula um banco de dados na memoria
        public static List<Flight> Flights = new List<Flight>();
        public static List<User> Users = new List<User>();
        public static List<Reservation> Reservations = new List<Reservation>();
    }
}
