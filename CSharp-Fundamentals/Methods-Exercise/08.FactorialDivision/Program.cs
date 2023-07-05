using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main()
        {
            int[] integers = new int[2];
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{FactorialDivision(integers):f2}");
        }

        private static double FactorialDivision(int[] integers)
        {
            double[] factorials = new double[integers.Length];
            double result = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                factorials[i] = 1;
                for (int j = 1; j <= integers[i]; j++)
                {
                    factorials[i] *= j;
                }
            }
            result = factorials[0] / factorials[1];
            return result;
        }
    }
}