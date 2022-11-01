using Flights.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaneController : Controller
    {
      
        private readonly IPlaneService _planeService;
        public PlaneController(IPlaneService planeService)
        {
            _planeService = planeService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_planeService.Get());
        }
    }
}
