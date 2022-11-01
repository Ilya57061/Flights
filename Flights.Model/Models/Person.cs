

using System.ComponentModel.DataAnnotations.Schema;

namespace Flights.Model.Models
{
    [Table("Persons")]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
      
    }
}
