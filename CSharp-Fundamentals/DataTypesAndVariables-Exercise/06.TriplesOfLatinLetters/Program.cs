using System;

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                char char1 = (char)('a' + i);
                for (int j = 0; j < input; j++)
                {
                    char char2 = (char)('a' + j);
                    for (int k = 0; k < input; k++)
                    {
                        char char3 = (char)('a' + k);
                        Console.WriteLine($"{char1}{char2}{char3}");
                    }
                }
            }
        }
    }
}
