using System;
using System.Diagnostics.Metrics;
using System.Transactions;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int biggestCounter = 1;
            int? previousNum = null;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == previousNum)
                {
                    counter++;

                    if (counter >= biggestCounter)
                    {
                        index = i;
                        biggestCounter++;
                    }
                }
                else
                {
                    counter = 0;
                }
                previousNum = arr[i];
            }

            for (int j = 0; j < biggestCounter; j++)
            {
                Console.Write($"{arr[index]} ");
            }

        }
    }
}