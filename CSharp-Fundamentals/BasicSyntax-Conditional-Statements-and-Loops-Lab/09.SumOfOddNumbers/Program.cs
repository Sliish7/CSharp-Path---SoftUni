using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= input * 2; i+= 2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
