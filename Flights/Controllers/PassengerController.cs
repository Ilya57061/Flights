using Flights.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PassengerController : Controller
    {

        private readonly IPassengerService _passengerService;
        public PassengerController(IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }
        [HttpPost]
        public ActionResult Passengers([FromForm]int passengers, [FromForm] int idFlight)
        {
            ViewBag.Passengers = passengers;
            ViewBag.IdFlight = idFlight;
            return View("~/Pages/Passenger.cshtml");
        }

    }
}
