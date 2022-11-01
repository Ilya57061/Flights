
using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Model.Models
{
    [Table("Aircompanies")]
    public class Aircompany
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; }=string.Empty;
        public string Address { get; set; }= string.Empty;
        public List<Plane>? Planes { get; set; }
    }
}
