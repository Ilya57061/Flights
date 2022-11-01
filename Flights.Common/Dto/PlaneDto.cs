
using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Common.Dto
{
    public class PlaneDto
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public ushort CountSeats { get; set; }
        public int AircompanyId { get; set; }
    }
}
 