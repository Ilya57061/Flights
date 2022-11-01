
using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Model.Models
{
    [Table("Planes")]
    public class Plane
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public ushort CountSeats { get; set; }
        public int AircompanyId { get; set; }
        public Aircompany? Aircompany { get; set; }
        public List<Flight>? Flights { get; set; }
    }
}
 