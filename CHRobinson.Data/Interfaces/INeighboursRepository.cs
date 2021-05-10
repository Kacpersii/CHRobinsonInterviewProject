using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHRobinson.Data.Interfaces
{
    public interface INeighboursRepository
    {
        bool AreNeighbours(int id1, int id2);
    }
}
