using CHRobinson.Data.Models;
using CHRobinson.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CHRobinsonInterviewProject.Controllers
{
    [Route("")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        private CountryRepository _countries = new CountryRepository();

        [HttpGet("{destinationCountryCode}")]
        public List<Country> GetRoute(string destinationCountryCode)
        {
            return _countries.GetAllCountries();
        }
    }
}
