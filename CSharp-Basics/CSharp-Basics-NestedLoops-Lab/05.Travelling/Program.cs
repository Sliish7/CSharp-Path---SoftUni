using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main()
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double moneyNeeded = double.Parse(Console.ReadLine());
                double budget = 0;

                while (budget < moneyNeeded)
                {
                    double savedAmount = double.Parse(Console.ReadLine());
                    budget += savedAmount;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}