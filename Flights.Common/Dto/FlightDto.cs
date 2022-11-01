
using System.ComponentModel.DataAnnotations.Schema;

namespace Flights.Common.Dto
{
    public class FlightDto
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Duration { get; set; }
        public decimal Econom { get; set; }
        public decimal Business { get; set; }
        public int CountSeats { get; set; }
        public string Status { get; set; } = string.Empty;
        public int PlaneId { get; set; }
        public int ArrivalAirportId { get; set; }
        public int StartAirportId { get; set; }

    }
}
