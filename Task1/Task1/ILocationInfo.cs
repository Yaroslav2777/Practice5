using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface ILocationInfo
    {
        string Name { get; set; }
        string Address { get; set; }

        long GetPopulation();
        double GetArea();
    }
}

