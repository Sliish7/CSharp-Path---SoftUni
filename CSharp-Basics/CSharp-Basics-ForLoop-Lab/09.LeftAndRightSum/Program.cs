using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < input; i++)
            {
                int left = int.Parse(Console.ReadLine());
                leftsum += left;
            }
            for (int i = 0; i < input; i++)
            {
                int right = int.Parse(Console.ReadLine());
                rightsum+= right;
            }

            int result = Math.Abs(rightsum - leftsum);

            if (result == 0)
            {
                Console.WriteLine($"Yes, sum = {leftsum}");
            }
            else
                Console.WriteLine($"No, diff = {result}");
        }
    }
}
