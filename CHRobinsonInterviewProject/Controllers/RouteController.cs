using CHRobinson.Data.Models;
using CHRobinson.Data.Repositories;
using Microsoft.AspNetCore.Cors;
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
        private NeighboursRepository _neighbours = new NeighboursRepository();
        private RouteRepository _route = new RouteRepository();

        [EnableCors]
        [HttpGet("{destinationCountryCode}")]
        public IActionResult GetRoute(string destinationCountryCode)
        {
            var val = new { destination = destinationCountryCode, list = _route.RouteFromUsaToDestination(destinationCountryCode) };
            if(val.list == null)
            {
                return NotFound();
            }
            return Ok(val);
        }
    }
}
