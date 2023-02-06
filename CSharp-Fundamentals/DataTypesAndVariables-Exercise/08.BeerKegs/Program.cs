using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main()
        {
            int kegsCount = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double biggestV = 0;

            for (int i = 1; i <= kegsCount; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double V = Math.PI * Math.Pow(radius, 2) * height;
                if (V > biggestV)
                {
                    biggestV = V;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
