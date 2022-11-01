

using System.ComponentModel.DataAnnotations.Schema;

namespace Flights.Common.Dto
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
      
    }
}
