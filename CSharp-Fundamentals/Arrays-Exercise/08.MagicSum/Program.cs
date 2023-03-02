using System;
using System.Runtime.ExceptionServices;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int magicNum = int.Parse(Console.ReadLine());
            int firstNum = 0; int secondNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                firstNum = numbers[i];

                for (int j = numbers.Length - 1; j > i; j--)
                {
                    int totalSum = 0;
                    if (j != i)
                    {
                        secondNum = numbers[j];
                            totalSum = firstNum + secondNum;

                        if (totalSum == magicNum )
                        {
                            Console.WriteLine($"{numbers[i]} {numbers[j]}");
                        }
                    }
                }
            }
        }
    }
}
