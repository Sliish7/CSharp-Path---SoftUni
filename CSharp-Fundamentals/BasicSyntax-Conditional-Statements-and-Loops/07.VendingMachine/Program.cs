using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double totCoins = 0;

            while (input != "Start")
            {
                double coin = Convert.ToDouble(input);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2 )
                {
                    totCoins += coin;
                }
                else
                    Console.WriteLine($"Cannot accept {coin}");

                input = Console.ReadLine();
            }

            while (input != "End")
            {
                input = Console.ReadLine();
                string product = input;

                switch (product)
                {
                    case "Nuts": double price = 2.0; Vending(price,ref totCoins, product); break;
                    case "Water": price = 0.7; Vending(price,ref totCoins, product); break;
                    case "Crisps": price = 1.5; Vending(price,ref totCoins, product); break;
                    case "Soda": price = 0.8; Vending(price,ref totCoins, product); break;
                    case "Coke": price = 1.0; Vending(price,ref totCoins, product); break;
                    case "End": break;
                    default: Console.WriteLine("Invalid product"); break;
                }               
            }
            Console.WriteLine($"Change: {totCoins:f2}");
        }

        static double Vending (double price,ref double totCoins, string product)
        {
            if (totCoins >= price)
            {
                totCoins -= price;
                Console.WriteLine($"Purchased {product.ToLower()}");
                return totCoins;
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
                return 0;
            }
        }

    }
}
