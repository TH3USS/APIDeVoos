using FlightBookingApi.Data;
using FlightBookingApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Reservation> GetReservations()
        {
            return FakeDatabase.Reservations;
        }

        [HttpPost]
        public IActionResult MakeReservation([FromBody] Reservation reservation)
        {
            var user = FakeDatabase.Users.FirstOrDefault(u => u.Id == reservation.UserId);
            var flight = FakeDatabase.Flights.FirstOrDefault(f => f.Id == reservation.FlightId);

            if (user == null || flight == null)
            {
                return NotFound("User or Flight not found.");
            }

            reservation.ReservationDate = DateTime.Now;
            reservation.IsConfirmed = true;
            FakeDatabase.Reservations.Add(reservation);
            return CreatedAtAction(nameof(GetReservations), new { id = reservation.Id }, reservation);
        }
    }
}
