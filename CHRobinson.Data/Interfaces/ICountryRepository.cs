using CHRobinson.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRobinson.Data.Interfaces
{
    interface ICountryRepository
    {
        List<Country> GetAllCountries();
        Country GetCountry(int id);
        Country GetCountryByCode(string code);
    }
}
