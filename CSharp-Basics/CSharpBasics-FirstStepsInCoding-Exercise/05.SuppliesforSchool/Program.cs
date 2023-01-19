using System;

namespace _05.SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaning = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double price = pens * 5.80 + markers * 7.20 + cleaning * 1.20;
            double priceAftDisc = price - (price * (discount / 100));
            Console.WriteLine(priceAftDisc);
        }
    }
}
