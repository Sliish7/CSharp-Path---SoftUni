using System;

namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int n1 = int.Parse(input[0]);
                int n2 = int.Parse(input[1]);

                if (i % 2 == 0)
                {
                    arr1[i] = n1;
                    arr2[i] = n2;
                }
                else
                {
                    arr1[i] = n2;
                    arr2[i] = n1;
                }
            }

            string out1 = string.Join(" ", arr1);
            string out2 = string.Join(" ", arr2);

            Console.WriteLine($"{out1}\n{out2}");

        }
    }
}