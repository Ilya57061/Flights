
using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Common.Dto
{
    [Table("Airports")]
    public class AirportDto
    {
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
