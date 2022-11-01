

using System.ComponentModel.DataAnnotations.Schema;

namespace Flights.Model.Models
{
    [Table("Passengers")]
    public class Passenger : Person
    {
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string DocNumber { get; set; } = string.Empty;
        public Ticket? Ticket { get; set; }
    }
}
