using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Model.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        public int Id { get; set; } 
        public int? BuyerId { get; set; }
        public Buyer? Buyer { get; set; }
        public int PassengerId { get; set; }
        public Passenger? Passenger { get; set; }
        public int FlightId { get;set; }
        public Flight? Flight { get; set; }
    }
}
