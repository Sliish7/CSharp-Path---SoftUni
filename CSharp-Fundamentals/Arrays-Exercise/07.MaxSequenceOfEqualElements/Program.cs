using System;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int counter = 0; int max = 0; string num = string.Empty;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (max < counter)
                    {
                        max = counter;
                        num = numbers[i].ToString();
                    }
                }
                else
                    counter = 0;
            }

            for (int i = 0; i <= max; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
