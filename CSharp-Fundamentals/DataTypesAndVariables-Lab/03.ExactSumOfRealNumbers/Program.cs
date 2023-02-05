using System;

namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main()
        {
            int nums = int.Parse(Console.ReadLine());
            decimal result = 0;
            for (int i = 1; i <= nums; i++)
            {
                decimal n = decimal.Parse(Console.ReadLine());
                result += n;
            }
            Console.WriteLine(result);
        }
    }
}
