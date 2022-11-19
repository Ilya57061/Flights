
using Flights.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Flights.Model.Database
{
    public class ApplicationContext:DbContext
    {
       
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
          
        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Airport> Airports { get; set; }
    }
}
