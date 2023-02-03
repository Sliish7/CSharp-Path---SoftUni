using System;

namespace _01.SortNumbers_ME
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] numbers = { num1, num2, num3 };
            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
