using CHRobinson.Data.Interfaces;
using CHRobinson.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRobinson.Data.Repositories
{
    public class RouteRepository : IRouteRepository
    {
        private CountryRepository _countries = new CountryRepository();
        private NeighboursRepository _neighbours = new NeighboursRepository();

        public List<string> RouteFromUsaToDestination(string destinationCountryCode)
        {
            destinationCountryCode = destinationCountryCode.ToUpper();
            var countries = _countries.GetAllCountries();
            Country country = countries.Find(c => c.Code == "USA");
            Country destinationCountry = countries.Find(c => c.Code == destinationCountryCode);
            if(destinationCountry == null)
            {
                return null;
            }

            Queue<Country> queue = new Queue<Country>();
            queue.Enqueue(country);

            bool[] visited = new bool[countries.Count];
            Country[] previousCountries = new Country[countries.Count];

            while (queue.Count > 0 && country.Code != destinationCountryCode)
            {
                country = queue.Dequeue();

                if (!visited[country.Id])
                {
                    visited[country.Id] = true;

                    for (int i = 0; i < countries.Count; i++)
                    {
                        if (_neighbours.AreNeighbours(country.Id, i) == true)
                        {
                            if (previousCountries[i] == null)
                            {
                                previousCountries[i] = country;
                            }
                            queue.Enqueue(countries[i]);
                        }
                    }
                }
            }

            List<string> route = new List<string>();
            route.Add(country.Code);

            while (country.Code != "USA")
            {
                country = previousCountries[country.Id];
                route.Add(country.Code);
            }
            route.Reverse();
            return route;
        }
    }
}
