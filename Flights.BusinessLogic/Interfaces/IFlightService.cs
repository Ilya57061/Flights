using Flights.Common.Dto;
namespace Flights.BusinessLogic.Interfaces
{
    public interface IFlightService
    {
        FlightDto Get(int id);
        IEnumerable<FlightDto> Get(FlightFindDto model);
        void Create(FlightDto model);
        void UpdateSeats(int id, int countSeats);
        DateTime GetTimeFlight(int id);
    }
}
