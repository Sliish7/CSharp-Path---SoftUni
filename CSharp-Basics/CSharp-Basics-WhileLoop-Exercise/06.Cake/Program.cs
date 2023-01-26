using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main()
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int totalPieces = cakeWidth * cakeLength;

            while (totalPieces >= 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                else
                totalPieces-= Convert.ToInt32(input);                
            }

            if (totalPieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            }
            else
                Console.WriteLine($"{totalPieces} pieces are left.");
        }
    }
}
