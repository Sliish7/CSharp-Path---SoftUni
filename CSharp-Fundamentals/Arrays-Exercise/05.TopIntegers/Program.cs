using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool isTop = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                int index = i + 1;

                for (int j = index; j < numbers.Length; j++)
                {
                    int A = numbers[i]; int B = numbers[j];

                    if (numbers[i] < numbers[j])
                    {
                        isTop = false;
                        break;
                    }
                    else
                        isTop= true;
                }

                if (isTop || index >= numbers.Length)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
