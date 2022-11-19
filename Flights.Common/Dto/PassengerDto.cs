

using System.ComponentModel.DataAnnotations;

namespace Flights.Common.Dto
{
    public class PassengerDto : PersonDto
    {
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string DocNumber { get; set; } = string.Empty;
    }
}
