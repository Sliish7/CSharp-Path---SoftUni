using System;

namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int stop = 1;

            while (num >= stop)
            {
                Console.WriteLine(stop);
                stop = stop * 2 + 1;
            }
        }
    }
}
