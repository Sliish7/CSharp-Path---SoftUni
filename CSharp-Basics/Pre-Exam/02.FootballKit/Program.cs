using System;

namespace _02.FootballKit
{
    internal class Program
    {
        static void Main()
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sumNeeded = double.Parse(Console.ReadLine());
            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.20;
            double shoesPrice = 2 * (tshirtPrice + shortsPrice);
            double totalPrice = tshirtPrice + socksPrice + shortsPrice + shoesPrice;
            totalPrice -= totalPrice * 0.15;

            if (totalPrice >= sumNeeded)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPrice:f2} lv.");
            }
            else
            {
                
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sumNeeded - totalPrice:f2} lv. more.");
            }
        }
    }
}
