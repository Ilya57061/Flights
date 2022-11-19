using Flights.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PassengerController : Controller
    {

        private readonly IPassengerService _passengerService;
        private readonly IFlightService _flightService;
        public PassengerController(IPassengerService passengerService, IFlightService flightService)
        {
            _passengerService = passengerService;
            _flightService = flightService;
        }
        [HttpPost]
        public ActionResult Passengers([FromForm]int passengers, [FromForm] int idFlight)
        {
            ViewBag.Passengers = passengers;
            ViewBag.Price = _flightService.Get(idFlight).Econom*passengers;
            ViewBag.idFlight = idFlight;
            return View("~/Pages/Passenger.cshtml");
        }

    }
}
