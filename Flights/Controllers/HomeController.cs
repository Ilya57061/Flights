using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View("~/Pages/Index.cshtml");
        }
        [Route("p")]
        public IActionResult Passengers()
        {
            ViewBag.Passengers = 1;
            @ViewBag.IdFlight=1;
            return View("~/Pages/Passenger.cshtml");
        }
 
    }
}
