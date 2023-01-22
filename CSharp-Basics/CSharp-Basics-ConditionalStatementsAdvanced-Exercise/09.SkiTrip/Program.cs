using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rate = Console.ReadLine();
            double price = 0;
            int nights = days - 1;


            switch (room)
            {
                case "room for one person":
                    price = 18;
                    price *= nights;
                    break;
                case "apartment":
                    price = 25;

                    if (days > 15)
                    {
                        price *= nights;
                        price *= 0.50;
                    }
                    else if (days < 10)
                    {
                        price *= nights;
                        price *= 0.70;
                    }
                    else
                    {
                        price *= nights;
                        price *= 0.65;
                    }
                    break;
                case "president apartment":
                    price = 35;

                    if (days > 15)
                    {
                        price *= nights;
                        price *= 0.80;
                    }
                    else if (days < 10)
                    {
                        price *= nights;
                        price *= 0.90;
                    }
                    else
                    {
                        price *= nights;
                        price *= 0.85;
                    }
                    break;
                default:
                    break;
            }

            if (rate == "positive")
            {
                price *= 1.25;
            }
            else
                price *= 0.90      ;
            Console.WriteLine($"{price:f2}");
        }
    }
}
