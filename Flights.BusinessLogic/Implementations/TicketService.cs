using AutoMapper;
using Flights.BusinessLogic.Interfaces;
using Flights.Common.Dto;
using Flights.Common.Mapper;
using Flights.Model.Database;
using Flights.Model.Models;

namespace Flights.BusinessLogic.Implementations
{
    public class TicketService : ITicketService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public TicketService(ApplicationContext context,IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }
        public void Create(TicketDto model)
        {
            _context.Tickets.Add(_mapper.Map<Ticket>(model));
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Remove(Find(id));
            _context.SaveChanges();
        }
        private Ticket Find(int id)
        {
            Ticket ticket = _context.Tickets.FirstOrDefault(x => x.Id == id);
            if (ticket is null)
            {
                throw new Exception("Ticket null");
            }
            return ticket;
        }
    }
}
