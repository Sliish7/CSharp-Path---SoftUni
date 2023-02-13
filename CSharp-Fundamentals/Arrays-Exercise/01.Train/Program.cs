using System;
using System.Xml.Schema;

namespace _01.Train
{
    internal class Program
    {
        static void Main()
        {
            int[] wagons = new int[int.Parse(Console.ReadLine())];
            int totalP = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
            }

            foreach (var passengers in wagons)
            {
                totalP += passengers;
                Console.Write($"{passengers} ");
            }
            Console.WriteLine("\n" + totalP);
        }
    }
}
