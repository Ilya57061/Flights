
using System.ComponentModel.DataAnnotations.Schema;

namespace Flights.Model.Models
{
    [Table("Flights")]
    public class Flight
    {
        public int Id { get; set; }
        public List<Ticket>? Tickets { get; set; }
        public DateTime Start { get; set; }
        public DateTime Duration { get; set; }
        public int CountSeats { get; set; }
        public decimal Econom { get; set; }
        public decimal Business { get; set; }
        public string Status { get; set; } = string.Empty;
        public int PlaneId { get; set; }
        public Plane? Plane { get; set; }
        public int ArrivalAirportId { get; set; }
        public int StartAirportId { get; set; }

    }
}
