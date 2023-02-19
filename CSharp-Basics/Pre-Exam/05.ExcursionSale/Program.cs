using System;

namespace _05.ExcursionSale
{
    internal class Program
    {
        static void Main()
        {
            int tripSeaCount = int.Parse(Console.ReadLine());
            int tripMountainCount = int.Parse(Console.ReadLine());
            int seaPrice = 680;
            int mountainPrice = 499;
            int profit = 0;

            string input = "";
            bool isSold = false;

            while (input != "Stop")
            {
                input = Console.ReadLine();

                if (input == "sea" && tripSeaCount > 0)
                {
                    profit += seaPrice;
                    tripSeaCount--;
                }
                else if (input == "mountain" && tripMountainCount > 0)
                {
                    profit += mountainPrice;
                    tripMountainCount--;
                }


                if (tripMountainCount == 0 && tripSeaCount == 0)
                {
                    isSold = true;
                    break;
                }
            }

            if (isSold)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
