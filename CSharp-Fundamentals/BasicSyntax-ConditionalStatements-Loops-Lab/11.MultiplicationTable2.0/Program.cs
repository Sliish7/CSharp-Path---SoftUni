using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int range = int.Parse(Console.ReadLine());

            if (range <= 10)
            {
                for (int i = range; i <= 10; i++)
                {
                    int res = n * i;
                    Console.WriteLine($"{n} X {i} = {res}");
                }
            }
            else
                Console.WriteLine($"{n} X {range} = {n * range}");

        }
    }
}
