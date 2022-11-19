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
 
 
    }
}
