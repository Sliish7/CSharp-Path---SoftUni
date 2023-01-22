using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double moneySpent = 0;
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "winter")
                {
                    moneySpent = budget * 0.70;
                }
                else
                {
                    moneySpent = budget * 0.30;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "winter")
                {
                    moneySpent = budget * 0.80;
                }
                else
                {
                    moneySpent = budget * 0.40;
                }
            }
            else 
            {
                destination = "Europe";
                moneySpent = budget * 0.90;
            }

            if (budget > 1000)
            {
                place = "Hotel";
            }
            else if (season == "winter")
            {
                place = "Hotel";
            }
            else if (season == "summer")
            {
                place = "Camp";
            }
                


            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {moneySpent:f2}");
        }
    }
}
