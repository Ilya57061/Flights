using Flights.BusinessLogic.Interfaces;
using Flights.Common.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TicketController : Controller
    {
        private readonly IPassengerService _passengerService;
        private readonly ITicketService _ticketService;
        private readonly IBuyerService _buyerService;
        private readonly IFlightService _flightService;
        private readonly IEmailService _emailService;
        public TicketController(IPassengerService passengerService, ITicketService ticketService, 
            IBuyerService buyerService, IFlightService flightService, IEmailService emailService)
        {
            _passengerService = passengerService;
            _ticketService = ticketService;
            _buyerService = buyerService;
            _flightService = flightService;
            _emailService = emailService;
        }

        [HttpPost]
        public ActionResult Create([FromForm] List<PassengerDto> passengers, [FromForm]BuyerDto buyer, [FromForm] int idFlight)
        {
            _buyerService.Create(buyer);
            _flightService.UpdateSeats(idFlight, passengers.Count);
            string info = string.Empty;
            DateTime timeStart = _flightService.GetTimeFlight(idFlight);
            foreach (var item in passengers)
            {
                info += $"\n{item.FirstName} {item.LastName}, {item.DocNumber}. Дата вылета: {timeStart}";
                _passengerService.Create(item);
                
                TicketDto ticket = new TicketDto {Buyer=buyer, Passenger = item, FlightId = idFlight };
                _ticketService.Create(ticket);
            }
            _emailService.Send(buyer.Mail, "Покупка билетов", info);

            ViewBag.IdFlight = idFlight;

            return View("~/Pages/Index.cshtml");
        }
    }
}
