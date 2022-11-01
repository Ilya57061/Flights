namespace Flights.Common.Dto
{
    public class FlightFindDto
    {
        public DateTime Start { get; set; }
        public DateTime Duration { get; set; }
        public string ArrivalAddress { get; set; }=string.Empty;
        public string StartAddress { get; set; } = string.Empty;
        public int CountSeats { get; set; }
    
    }
}
