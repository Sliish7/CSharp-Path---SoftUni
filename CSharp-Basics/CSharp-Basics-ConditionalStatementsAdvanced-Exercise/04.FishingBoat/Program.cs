using System;
using System.Xml.Schema;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double total = 0;

            switch (season)
            {
                case "Spring":
                    total = 3000;
                    break;
                case "Summer":
                    total = 4200;
                    break;
                case "Autumn":
                    total = 4200;
                    break;
                case "Winter":
                    total = 2600;
                    break;
                default:
                    break;
            }

            if (fishermans <= 6)
            {
                total *= 0.90;
            }
            else if (fishermans >= 7 && fishermans <= 11)
            {
                total *= 0.85;
            }
            else if (fishermans >= 12)
            {
                total *= 0.75;
            }

            if (fishermans % 2 == 0 && season != "Autumn")
            {
                total *= 0.95;
            }

            if (total > budget)
            {
                double moneyNeeded = total - budget;
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyNeeded):f2} leva.");
            }
            else
            {
                double moneyLeft = budget - total;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
        }
    }
}
