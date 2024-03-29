﻿namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = numbers.Length - 1;
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                int[] condensed = new int[numbers.Length - 1];

                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                }

                numbers = condensed;
                result = condensed[0];
            }

            if (numbers.Length == 1)
            {
                result = numbers[numbers.Length - 1];
            }
            Console.WriteLine(result);
        }    
    }
}