using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Common.Dto
{
    public class TicketDto
    {
        public int Id { get; set; }
        public PassengerDto? Passenger { get; set; }
        public BuyerDto? Buyer { get; set; }
        public int FlightId { get; set; }
    }
}
