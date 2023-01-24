using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main()
        {
            int tournCount = int.Parse(Console.ReadLine());
            int startingpoints = int.Parse(Console.ReadLine());
            int points = 0;

            double pW = 0;

            for (int i = 0; i < tournCount; i++)
            {
                string type = Console.ReadLine();

                switch (type)
                {
                    case "W":
                        points += 2000;
                        pW++;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                    default:
                        break;
                }
            }

            pW = pW / tournCount * 100;
            int avgPoints = points / tournCount;

            Console.WriteLine($"Final points: {points + startingpoints}");
            Console.WriteLine($"Average points: {Math.Abs(avgPoints)}");
            Console.WriteLine($"{pW:f2}%");
        }
    }
}
