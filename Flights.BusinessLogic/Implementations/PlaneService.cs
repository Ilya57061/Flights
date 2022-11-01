using Flights.BusinessLogic.Interfaces;
using Flights.Model.Database;
using Microsoft.EntityFrameworkCore;
using System.Numerics;


namespace Flights.BusinessLogic.Implementations
{
    public class PlaneService : IPlaneService
    {
        private readonly ApplicationContext _context;
        public PlaneService(ApplicationContext context)
        {
            _context = context;
        }
        public IEnumerable<Plane> Get()
        {
            var models = (IEnumerable<Plane>)_context.Planes.AsNoTracking().ToList();
            return models;
        }
    }
}
