using CHRobinson.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRobinson.Data.Interfaces
{
    public interface IRouteRepository
    {
        List<string> RouteFromUsaToDestination(string destinationCountryCode);
    }
}
