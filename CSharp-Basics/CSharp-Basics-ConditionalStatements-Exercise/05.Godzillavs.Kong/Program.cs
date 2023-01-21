using System;

namespace _05.Godzillavs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double eqPrice = double.Parse(Console.ReadLine());
            double totaleqPrice = statists * eqPrice;
            double decore = budget * 0.10;

            if (statists > 150)
            {
                totaleqPrice -= totaleqPrice * 0.10;
            }

            double totalSpent = decore + totaleqPrice;

            if (budget >= totalSpent)
            {
                double remMoney = budget - totalSpent;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remMoney:0.00} leva left.");
            }
            else
            {
                double remMoney = totalSpent - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {remMoney:0.00} leva more.");
            }
        }
    }
}
