using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public class City : Location, ILocationInfo
    {

        public int NumberOfDistricts { get; set; }

        public City(string name, string address, long population, double area, int districts)
            : base(name, address, population, area)
        {
            NumberOfDistricts = districts;
        }


        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        public long GetPopulation()
        {
            return _population;
        }
        public double GetArea()
        {
            return _area;
        }
        public void DisplayCityInfo()
        {
            Console.WriteLine($"--- Інформація про місто ---");
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Адреса (країна): {Address}");
            Console.WriteLine($"Площа: {GetArea():F2} кв. км");
            Console.WriteLine($"Населення: {GetPopulation()} осіб");
            Console.WriteLine($"Кількість районів: {NumberOfDistricts}");
        }
    }
}
