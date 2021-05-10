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
            countries = new List<Country>()
            {
                new Country{ Id = 0, Name = "Canada", Code = "CAN" },
                new Country{ Id = 1, Name = "The United States", Code = "USA" },
                new Country{ Id = 2, Name = "Mexico", Code = "MEX" },
                new Country{ Id = 3, Name = "Belize", Code = "BLZ" },
                new Country{ Id = 4, Name = "Guatemala", Code = "GTM" },
                new Country{ Id = 5, Name = "El Salvador", Code = "SLV" },
                new Country{ Id = 6, Name = "Honduras", Code = "HND" },
                new Country{ Id = 7, Name = "Nicaragua", Code = "NIC" },
                new Country{ Id = 8, Name = "Costa Rica", Code = "CRI" },
                new Country{ Id = 9, Name = "Panama", Code = "PAN" },
            };
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
