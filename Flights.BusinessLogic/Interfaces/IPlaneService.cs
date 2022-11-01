using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Flights.BusinessLogic.Interfaces
{
    public interface IPlaneService
    {
        IEnumerable<Plane> Get();
    }
}
