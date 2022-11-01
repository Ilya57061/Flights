using Flights.Common.Dto;
namespace Flights.BusinessLogic.Interfaces
{
    public interface IBuyerService
    {
        BuyerDto Get(int id);
        void Create(BuyerDto model);
        void Update();
        void Delete(int id);
    }
}
