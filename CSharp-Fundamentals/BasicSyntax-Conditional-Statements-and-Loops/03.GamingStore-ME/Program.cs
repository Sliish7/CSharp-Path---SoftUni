using System;
using System.Linq;
using System.Reflection.Metadata;

namespace _03.GamingStore_ME
{
    internal class Program
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            double currBal = balance;

            while (currBal >= 0)
            {
                string game = Console.ReadLine();
                if (game == "Game Time")
                {
                    break;
                }

                double gamePrice = 0;
                switch (game)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default: break;
                }

                if (game != "OutFall 4" && game != "CS: OG" && game != "Zplinter Zell" && game != "Honored 2" && game != "RoverWatch" && game != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }
                else if (currBal - gamePrice < 0)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currBal -= gamePrice;
                    Console.WriteLine($"Bought {game}");
                }
            }
            if (currBal == 0.00)
            {
                Console.WriteLine("Out of money!");
            }
            else
                Console.WriteLine($"Total spent: ${balance - currBal:f2}. Remaining: ${currBal:f2}");
        }

    }
}
