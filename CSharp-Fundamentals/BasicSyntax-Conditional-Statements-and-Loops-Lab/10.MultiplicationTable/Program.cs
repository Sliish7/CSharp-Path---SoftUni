using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int res = n * i;
                Console.WriteLine($"{n} X {i} = {res}");
            }
        }
    }
}
