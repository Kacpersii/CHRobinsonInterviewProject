using CHRobinson.Data.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CHRobinsonInterviewProject.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private CountryRepository _countries = new CountryRepository();

        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            var country = _countries.GetCountry(id);
            if (country == null)
            {
                return NotFound();
            }
            string jsonCountry = JsonSerializer.Serialize(country);
            return Ok(jsonCountry);
        }

        [HttpGet("byCode/{code}")]
        public IActionResult GetCountryByCode(string code)
        {
            var country = _countries.GetCountryByCode(code);
            if (country == null)
            {
                return NotFound();
            }
            string jsonCountry = JsonSerializer.Serialize(country);
            return Ok(jsonCountry);
        }

        [HttpGet("byName/{name}")]
        public IActionResult GetCountryByName(string name)
        {
            var country = _countries.GetCountryByName(name);
            if (country == null)
            {
                return NotFound();
            }
            string jsonCountry = JsonSerializer.Serialize(country);
            return Ok(jsonCountry);
        }
    }
}
