
using System.ComponentModel.DataAnnotations.Schema;


namespace Flights.Common.Dto
{
    public class BuyerDto

    {
        public int Id { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;


    }
}
