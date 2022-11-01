using Flights.Common.Dto;
namespace Flights.BusinessLogic.Interfaces
{
    public interface IPassengerService
    {
        void Create(PassengerDto model);
        void Update();
        void Delete(int id);
    }
}
