using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Location
    {
        protected string _name;
        protected string _address;
        protected long _population;
        protected double _area;

        public Location(string name, string address, long population, double area)
        {
            _name = name;
            _address = address;
            _population = population;
            _area = area;
        }
    }
}

