
using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Common.Dto
{
    [Table("Aircompanies")]
    public class AircompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; }=string.Empty;
        public string Address { get; set; }= string.Empty;
    }
}
