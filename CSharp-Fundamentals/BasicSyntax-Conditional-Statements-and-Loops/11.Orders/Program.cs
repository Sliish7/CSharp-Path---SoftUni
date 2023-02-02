using System;
using System.Xml.Schema;

namespace _11.Orders
{
    internal class Program
    {
        static void Main()
        {
            int order = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 1; i <= order; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double days = double.Parse(Console.ReadLine());
                double count = double.Parse(Console.ReadLine());

                double coffePrice = price * days * count;
                total += coffePrice;

                Console.WriteLine($"The price for the coffee is: ${coffePrice:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
