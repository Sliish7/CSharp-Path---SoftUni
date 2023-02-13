using System;

namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[] arr1 = new int[rows];
            int[] arr2 = new int[rows];


            for (int i = 0; i < rows; i++)
            {
                int[] currNums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                if (i % 2 == 0)
                {
                    arr1[i] = currNums[0];
                    arr2[i] = currNums[1];
                }
                else
                {
                    arr1[i] = currNums[1];
                    arr2[i] = currNums[0];
                }
            }

            foreach (int number in arr1)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            foreach (int number in arr2)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
