using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paintThinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double sumOfMats = ((nylon + 2) * 1.50 + (paint + paint * 0.10) * 14.50 + paintThinner * 5.00 + 0.40);
            double pricePerH = sumOfMats * 0.3;
            double total = sumOfMats + pricePerH * hours;

            Console.WriteLine(total);
        }
    }
}
