using Flights.BusinessLogic.Interfaces;
using Flights.Common.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BuyerController : Controller
    {
        private readonly IBuyerService _buyerService;
        public BuyerController(IBuyerService buyerService)
        {
            _buyerService = buyerService;
        }
        [HttpPost]
        public ActionResult Create([FromForm]BuyerDto model)
        {
            
            _buyerService.Create(model);
            return View("~/Pages/Index.cshtml");
        }
    }
}
