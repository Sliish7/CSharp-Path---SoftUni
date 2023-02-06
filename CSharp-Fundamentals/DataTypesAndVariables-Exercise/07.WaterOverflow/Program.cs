using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int capacity = 255;
            int totalLitres = 0;

            for (int i = 1; i <= input; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                if (litres > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= litres;
                    totalLitres += litres;
                }
            }
            Console.WriteLine(totalLitres);
        }
    }
}
