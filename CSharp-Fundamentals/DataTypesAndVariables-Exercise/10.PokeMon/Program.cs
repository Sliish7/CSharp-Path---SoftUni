using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main()
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaust = int.Parse(Console.ReadLine());

            int remainingPower = power;
            int targetCount = 0;

            while (remainingPower >= distance)
            {
                remainingPower -= distance;
                targetCount++;

                if (power / 2 == remainingPower && exhaust != 0)
                {
                    remainingPower /= exhaust;
                }
            }

            Console.WriteLine(remainingPower);
            Console.WriteLine(targetCount);
        }
    }
}
