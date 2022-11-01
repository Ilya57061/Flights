using AutoMapper;
using Flights.BusinessLogic.Interfaces;
using Flights.Common.Dto;
using Flights.Model.Database;
using Flights.Model.Models;


namespace Flights.BusinessLogic.Implementations
{
    public class BuyerService : IBuyerService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        
        public BuyerService(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public BuyerDto Get(int id)
        {
            var model = _mapper.Map<BuyerDto>(Find(id));
            return model;
        }
        public void Create(BuyerDto model)
        {
            var buyer = _mapper.Map<Buyer>(model);
            _context.Buyers.Add(buyer);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Buyers.Remove(Find(id));
            _context.SaveChanges();
        }

    

        public void Update()
        {
            throw new NotImplementedException();
        }
        private Buyer Find(int id)
        {
            Buyer buyer = _context.Buyers.FirstOrDefault(x => x.Id == id);
            if (buyer is null)
            {
                throw new Exception("Buyer null");
            }
            return buyer;
        }
    }
}
