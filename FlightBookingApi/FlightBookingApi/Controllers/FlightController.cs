using FlightBookingApi.Data;
using FlightBookingApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightBookingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Flight> GetFlights()
        {
            return FakeDatabase.Flights;
        }

        [HttpPost]
        public IActionResult AddFlight([FromBody] Flight flight)
        {
            FakeDatabase.Flights.Add(flight);
            return CreatedAtAction(nameof(GetFlights), new { id = flight.Id }, flight);
        }
    }
}
