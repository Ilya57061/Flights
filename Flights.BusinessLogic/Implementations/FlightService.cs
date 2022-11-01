using AutoMapper;
using Flights.BusinessLogic.Interfaces;
using Flights.Common.Dto;
using Flights.Model.Database;
using Flights.Model.Models;


namespace Flights.BusinessLogic.Implementations
{
    public class FlightService : IFlightService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        
        public FlightService(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public FlightDto Get(int id)
        {
            var model = _mapper.Map<FlightDto>(Find(id));
            return model;
        }
        public DateTime GetTimeFlight(int id)
        {
            return Find(id).Start;
        }
        public IEnumerable<FlightDto> Get(FlightFindDto model)
        {

            var query = _context.Flights.Where(m => m!.ArrivalAirportId == GetAirport(model.ArrivalAddress) &&
            m!.StartAirportId == GetAirport(model.StartAddress) &&m!.Start.Date==model!.Start.Date);
            query = query.Where(m => m.CountSeats + model.CountSeats <= _context.Planes.FirstOrDefault(p => p.Id == m.PlaneId).CountSeats);

            var models = _mapper.Map <List<FlightDto>>(query);
            return models;
            
        }
        public void Create(FlightDto model)
        {
            var flight = _mapper.Map<Flight>(model);
            _context.Flights.Add(flight);
            _context.SaveChanges();
        }

        public void UpdateSeats(int id, int countSeats)
        {
            Flight flight = Find(id);
            flight.CountSeats+=countSeats;
            _context.Flights.Update(flight);
            _context.SaveChanges();
        }
        private Flight Find(int id)
        {
            Flight flight = _context.Flights.FirstOrDefault(x => x.Id == id);
            if (flight is null)
            {
                throw new Exception("Flight null");
            }
            return flight;
        }
        private int GetAirport(string address)
        {
            Airport airport = _context.Airports.FirstOrDefault(x=>x.Address==address);
            if (airport == null) throw new Exception();
            return airport.Id;
        }
      

     
    }
}
