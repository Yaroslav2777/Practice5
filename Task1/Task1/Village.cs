using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class Village : Location, ILocationInfo
    {
        // Специфічна властивість для сіл
        public bool HasPrimarySchool { get; set; }
        public Village(string name, string address, long population, double area, bool hasSchool)
            : base(name, address, population, area)
        {
            HasPrimarySchool = hasSchool;
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
        public void DisplayVillageInfo()
        {
            Console.WriteLine($"--- Інформація про село ---");
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Адреса (район/область): {Address}");
            Console.WriteLine($"Площа: {GetArea():F2} га");
            Console.WriteLine($"Населення: {GetPopulation()} осіб");
            Console.WriteLine($"Наявність початкової школи: {(HasPrimarySchool ? "Так" : "Ні")}");
        }
    }
}

