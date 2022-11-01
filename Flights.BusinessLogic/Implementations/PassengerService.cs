using AutoMapper;
using Flights.BusinessLogic.Interfaces;
using Flights.Common.Dto;
using Flights.Model.Database;
using Flights.Model.Models;


namespace Flights.BusinessLogic.Implementations
{
    public class PassengerService : IPassengerService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public PassengerService(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public PassengerDto Get(int id)
        {
            var model = _mapper.Map<PassengerDto>(Find(id));
            return model;
        }
        public void Create(PassengerDto model)
        {
            var passenger = _mapper.Map<Passenger>(model);
            _context.Passengers.Add(passenger);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Passengers.Remove(Find(id));
            _context.SaveChanges();
        }

    

        public void Update()
        {
            throw new NotImplementedException();
        }
        private Passenger Find(int id)
        {
            Passenger passenger = _context.Passengers.FirstOrDefault(x => x.Id == id);
            if (passenger is null)
            {
                throw new Exception("Buyer null");
            }
            return passenger;
        }
    }
}
