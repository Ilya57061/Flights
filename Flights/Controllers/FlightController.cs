using Flights.BusinessLogic.Interfaces;
using Flights.Common.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FlightController : Controller
    {
        private readonly IFlightService _flightService;
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }
  
        [HttpPost]
        public ActionResult Get([FromForm]FlightFindDto model, [FromForm] int adult, [FromForm] int kid, [FromForm] int baby)
        {
            ViewBag.Start = model.Start.ToString("d");
            ViewBag.Duration = model.Duration.Date;
            ViewBag.ArrivalAddress = model.ArrivalAddress;
            ViewBag.StartAddress = model.StartAddress;
            model.CountSeats = adult + kid + baby;
            ViewBag.Passengers = adult + kid + baby;
            ViewBag.Flights = _flightService.Get(model);

            return View("~/Pages/Flight.cshtml");
        }
  
    }
}
