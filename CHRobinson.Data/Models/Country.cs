using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRobinson.Data.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Country> Neighbours { get; set; }

        public Country()
        {
            Neighbours = new List<Country>();
        }
        public Country(int id, string name, string code)
        {
            Id = id;
            Name = name;
            Code = code;
            Neighbours = new List<Country>();
        }

        public bool IsNeighbour(Country country)
        {
            return Neighbours.Contains(country);
        }
    }
}
