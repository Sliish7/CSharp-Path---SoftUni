using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int highestNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > highestNum)
                {
                    highestNum = num;
                }
            }

            int resultWoHighest = sum - highestNum;
            if (resultWoHighest == highestNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {highestNum}");
            }
            else
            {
                int diff = Math.Abs(resultWoHighest - highestNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
