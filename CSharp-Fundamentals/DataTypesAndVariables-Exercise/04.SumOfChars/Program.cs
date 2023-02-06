using System;

namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main()
        {
            int numOfChars = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= numOfChars; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += Convert.ToInt32(letter);
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
