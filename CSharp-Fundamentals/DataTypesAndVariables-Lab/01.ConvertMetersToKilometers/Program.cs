using System;

namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main()
        {
            double meters = int.Parse(Console.ReadLine());
            double km = meters / 1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}
