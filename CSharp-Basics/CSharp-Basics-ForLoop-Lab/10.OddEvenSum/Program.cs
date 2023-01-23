using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int resOdd = 0;
            int resEven = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    resEven += num;
                }
                else
                    resOdd+= num;
            }

            int result = Math.Abs(resEven - resOdd);
            if (result == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {resOdd}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {result}");
            }
        }
    }
}
