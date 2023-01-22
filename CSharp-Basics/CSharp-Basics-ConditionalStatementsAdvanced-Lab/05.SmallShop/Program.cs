using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            switch (product)
            {
                case "coffee":
                    if (town == "Sofia")
                    {
                        price = 0.50 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Plovdiv")
                    {
                        price = 0.40 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Varna")
                    {
                        price = 0.45 * quantity;
                        Console.WriteLine(price);
                    }
                    break;
                case "water":
                    if (town == "Sofia")
                    {
                        price = 0.80 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Plovdiv")
                    {
                        price = 0.70 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Varna")
                    {
                        price = 0.70 * quantity;
                        Console.WriteLine(price);
                    }
                    break;
                case "beer":
                    if (town == "Sofia")
                    {
                        price = 1.20 * quantity;
                        Console.WriteLine(Math.Round(price,2));
                    }
                    else if (town == "Plovdiv")
                    {
                        price = 1.15 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Varna")
                    {
                        price = 1.10 * quantity;
                        Console.WriteLine(price);
                    }
                    break;
                case "sweets":
                    if (town == "Sofia")
                    {
                        price = 1.45 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Plovdiv")
                    {
                        price = 1.30 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Varna")
                    {
                        price = 1.35 * quantity;
                        Console.WriteLine(price);
                    }
                    break;
                case "peanuts":
                    if (town == "Sofia")
                    {
                        price = 1.60 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Plovdiv")
                    {
                        price = 1.50 * quantity;
                        Console.WriteLine(price);
                    }
                    else if (town == "Varna")
                    {
                        price = 1.55 * quantity;
                        Console.WriteLine(price);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
