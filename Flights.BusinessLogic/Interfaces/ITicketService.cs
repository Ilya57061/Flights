using Flights.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights.BusinessLogic.Interfaces
{
    public interface ITicketService
    {
        void Create(TicketDto model);
        void Delete(int id);
    }
}
