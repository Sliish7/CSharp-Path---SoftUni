using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalYield = 0;
            int days = 0;
            int consume = 26;

            while (startingYield >= 100)
            {
                days++;
                totalYield += startingYield;
                if (totalYield > consume)
                {
                    totalYield -= consume;
                }

                startingYield -= 10;
            }
            if (totalYield > consume)
            {
                totalYield -= consume;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalYield);
        }
    }
}
