using System;

namespace _02.PrintNumbersInReverse
{
    internal class Program
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            int[] numbers = new int[range];

            for (int i = 0; i < range; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                numbers[i] = currNum;
            }
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            //foreach (int num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}
        }
    }
}
