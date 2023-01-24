using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main()
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());

            for (int i = 0; i < jury; i++)
            {
                string juryName = Console.ReadLine();
                double pointsGiven = double.Parse(Console.ReadLine());

                points += ((juryName.Length) * pointsGiven) / 2;

                if (points > 1250.50 )
                {
                    i = jury;
                }
            }

            if (points < 1250)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - points:f1} more!");
            }
            else
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
        }
    }
}
