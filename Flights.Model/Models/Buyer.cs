
using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Model.Models
{
    [Table("Buyers")]
    public class Buyer
    {
        public int Id { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Mail { get; set; }=string.Empty;
        public List<Ticket>? Tickets { get; set; }


    }
}
