using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "Premiere":
                    double priceType = 12;
                    double total = row * col * priceType;
                    Console.WriteLine($"{total:f2} leva");
                    break;
                case "Normal":
                    priceType = 7.50;
                    total = row * col * priceType;
                    Console.WriteLine($"{total:f2} leva");
                    break;
                case "Discount":
                    priceType = 5;
                    total = row * col * priceType;
                    Console.WriteLine($"{total:f2} leva");
                    break;
                default:
                    break;
            }
        }
    }
}
