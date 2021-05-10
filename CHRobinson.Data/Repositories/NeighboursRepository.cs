using CHRobinson.Data.Interfaces;
using CHRobinson.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRobinson.Data.Repositories
{
    public class NeighboursRepository : INeighboursRepository
    {
        private List<Neighbours> neighbours;

        private CountryRepository _countries = new CountryRepository();

        public NeighboursRepository()
        {
            neighbours = new List<Neighbours>
            {
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("CAN"), SecondNeighbour = _countries.GetCountryByCode("USA")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("USA"), SecondNeighbour = _countries.GetCountryByCode("CAN")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("USA"), SecondNeighbour = _countries.GetCountryByCode("MEX")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("MEX"), SecondNeighbour = _countries.GetCountryByCode("USA")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("MEX"), SecondNeighbour = _countries.GetCountryByCode("GTM")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("MEX"), SecondNeighbour = _countries.GetCountryByCode("BLZ")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("BLZ"), SecondNeighbour = _countries.GetCountryByCode("MEX")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("BLZ"), SecondNeighbour = _countries.GetCountryByCode("GTM")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("GTM"), SecondNeighbour = _countries.GetCountryByCode("MEX")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("GTM"), SecondNeighbour = _countries.GetCountryByCode("BLZ")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("GTM"), SecondNeighbour = _countries.GetCountryByCode("SLV")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("GTM"), SecondNeighbour = _countries.GetCountryByCode("HND")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("SLV"), SecondNeighbour = _countries.GetCountryByCode("GTM")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("SLV"), SecondNeighbour = _countries.GetCountryByCode("HND")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("HND"), SecondNeighbour = _countries.GetCountryByCode("GTM")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("HND"), SecondNeighbour = _countries.GetCountryByCode("SLV")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("HND"), SecondNeighbour = _countries.GetCountryByCode("NIC")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("NIC"), SecondNeighbour = _countries.GetCountryByCode("HND")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("NIC"), SecondNeighbour = _countries.GetCountryByCode("CRI")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("CRI"), SecondNeighbour = _countries.GetCountryByCode("NIC")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("CRI"), SecondNeighbour = _countries.GetCountryByCode("PAN")},
                new Neighbours { FirstNeighbour = _countries.GetCountryByCode("PAN"), SecondNeighbour = _countries.GetCountryByCode("CRI")}
            };
        }

        public bool AreNeighbours(int id1, int id2)
        {
            var result = neighbours.Find(n => (n.FirstNeighbour.Id == id1 && n.SecondNeighbour.Id == id2) || (n.FirstNeighbour.Id == id2 && n.SecondNeighbour.Id == id1));
            return result != null;
        }
    }
}
