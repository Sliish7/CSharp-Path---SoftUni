using System;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main()
        {
            int[] array1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] array2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum = 0;
            bool isIdentical = true;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdentical = false;
                    break;
                }
                else
                    sum += array1[i];              
            }

            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
