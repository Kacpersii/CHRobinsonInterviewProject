using CHRobinson.Data.Interfaces;
using CHRobinson.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRobinson.Data.Repositories
{
    public class CountryRepository : ICountryRepository
    {
        List<Country> countries;
        public CountryRepository()
        {
            Country can = new Country(0, "Canada", "CAN");
            Country usa = new Country(1, "The United States", "USA");
            Country mex = new Country(2, "Mexico", "MEX");
            Country blz = new Country(3, "Belize", "BLZ");
            Country gtm = new Country(4, "Guatemala", "GTM");
            Country slv = new Country(5, "El Salvador", "SLV");
            Country hnd = new Country(6, "Honduras", "HND");
            Country nic = new Country(7, "Nicaragua", "NIC");
            Country cri = new Country(8, "Costa Rica", "CRI");
            Country pan = new Country(9, "Panama", "PAN");

            can.Neighbours.Add(usa);
            usa.Neighbours.Add(can);
            usa.Neighbours.Add(mex);
            mex.Neighbours.Add(usa);
            mex.Neighbours.Add(gtm);
            mex.Neighbours.Add(blz);
            blz.Neighbours.Add(mex);
            blz.Neighbours.Add(gtm);
            gtm.Neighbours.Add(mex);
            gtm.Neighbours.Add(blz);
            gtm.Neighbours.Add(slv);
            gtm.Neighbours.Add(hnd);
            slv.Neighbours.Add(gtm);
            slv.Neighbours.Add(hnd);
            hnd.Neighbours.Add(gtm);
            hnd.Neighbours.Add(slv);
            hnd.Neighbours.Add(nic);
            nic.Neighbours.Add(hnd);
            nic.Neighbours.Add(cri);
            cri.Neighbours.Add(nic);
            cri.Neighbours.Add(pan);
            pan.Neighbours.Add(cri);

            countries = new List<Country>()
            {
                can, usa, mex, blz, gtm, slv, hnd, nic, cri, pan
            };
        }

        public bool AreNeighbours(int id1, int id2)
        {
            var firstCountry = countries.Find(c => c.Id == id1);
            var secondCountry = countries.Find(c => c.Id == id2);

            return firstCountry.IsNeighbour(secondCountry);
        }

        public List<Country> GetAllCountries()
        {
            return countries;
        }

        public Country GetCountry(int id)
        {
            return countries.First(c => c.Id == id);
        }

        public Country GetCountryByCode(string code)
        {
            return countries.First(c => c.Code == code);
        }
    }
}
