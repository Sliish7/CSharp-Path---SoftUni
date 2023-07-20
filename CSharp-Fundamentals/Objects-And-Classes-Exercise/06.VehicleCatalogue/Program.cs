using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split(" ");
                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                decimal horsepower = decimal.Parse(arguments[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(vehicle);

            }

            vehicles.ForEach(x => x.Type = char.ToUpper(x.Type[0]) + x.Type.Substring(1));

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = command;
                Vehicle filteredVehicles = vehicles.Find(x => x.Model == model);

                if (filteredVehicles != null)
                {
                   Console.WriteLine(filteredVehicles.ToString());
                }
            }

            decimal avgCarHP = (decimal)vehicles.Where(x => x.Type == "Car")
                .Select(x => x.Horsepower)
                .DefaultIfEmpty()
                .Average();
            decimal avgTruckHP = (decimal)vehicles.Where(x => x.Type == "Truck")
                .Select(x => x.Horsepower)
                .DefaultIfEmpty()
                .Average();
            

            Console.WriteLine($"Cars have average horsepower of: {avgCarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHP:f2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, decimal horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Horsepower { get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"Type: {Type}\n";
            result += $"Model: {Model}\n";
            result += $"Color: {Color}\n";
            result += $"Horsepower: {Horsepower}";

            return result;
        }
    }
}