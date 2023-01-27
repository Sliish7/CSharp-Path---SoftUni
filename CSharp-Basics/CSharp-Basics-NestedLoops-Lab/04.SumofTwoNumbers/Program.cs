using System;

namespace _04.SumofTwoNumbers
{
    internal class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool isFound = false;

            for (int x = start; x <= end; x++)
            {
                for (int y = start; y <= end; y++)
                {
                    combinations++;
                    if (x + y == number)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({x} + {y} = {number})");
                        isFound= true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {number}");
            }
        }
    }
}
