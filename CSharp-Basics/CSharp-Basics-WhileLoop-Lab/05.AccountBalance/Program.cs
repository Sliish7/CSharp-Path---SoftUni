using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            double total = 0;
            double moneyIn = 0;

            while (input != "NoMoreMoney")
            {
                if (Convert.ToDouble(input) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    moneyIn = Convert.ToDouble(input);
                    Console.WriteLine($"Increase: {moneyIn:f2}");
                }
                total += moneyIn;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
