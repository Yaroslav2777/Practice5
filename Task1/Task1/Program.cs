using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--------------------------------------------------\n");

            City kyiv = new City(
                name: "Київ",
                address: "Україна",
                population: 2950000,
                area: 839.0, 
                districts: 10
            );

            Village kozyn = new Village(
                name: "Козин",
                address: "Обухівський район, Київська область",
                population: 3500,
                area: 600.5,
                hasSchool: true
            );

            ILocationInfo[] locations = new ILocationInfo[] { kyiv, kozyn };

            foreach (var loc in locations)
            {
                Console.WriteLine($"\nОб'єкт типу: {loc.GetType().Name}");
                Console.WriteLine($"Назва: {loc.Name}");
                Console.WriteLine($"Адреса: {loc.Address}");
                Console.WriteLine($"Населення: {loc.GetPopulation()} осіб");
                Console.WriteLine($"Площа: {loc.GetArea():F2}");
            }

            kyiv.DisplayCityInfo();
            Console.WriteLine();
            kozyn.DisplayVillageInfo();
            Console.WriteLine("\n--------------------------------------------------");
        }
    }
}