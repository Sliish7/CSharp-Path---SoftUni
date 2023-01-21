using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int toysCounter = puzzles+ dolls + bears + minions+ trucks;
            double discount = 0;
            double totalSpent = puzzles * 2.60 + dolls * 3 + bears * 4.10 +
                minions * 8.20 + trucks * 2;

            if (toysCounter >= 50)
            {
                discount = 0.25;
                totalSpent -= totalSpent * discount;
            }

            totalSpent -= totalSpent * 0.10;

            if (totalSpent < vacPrice)
            {
                double moneyRem = vacPrice - totalSpent;
                Console.WriteLine($"Not enough money! {moneyRem:0.00} lv needed.");
            }
            else
            {
                double moneyRem = totalSpent - vacPrice;
                Console.WriteLine($"Yes! {moneyRem:0.00} lv left.");
            }
        }
    }
}
