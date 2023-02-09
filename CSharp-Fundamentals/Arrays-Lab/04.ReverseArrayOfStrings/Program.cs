using System;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Array.Reverse(input);

            foreach (string el in input)
            {
                Console.Write($"{el} ");
            }
        }
    }
}
