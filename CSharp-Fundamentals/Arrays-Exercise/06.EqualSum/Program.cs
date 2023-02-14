using System;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            bool isFound = false;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                index = i;
                isFound = CheckSum(index, numbers, isFound);

                if (isFound)
                {
                    break;
                }
            }

        }

        static bool CheckSum(int index, int[] numbers, bool isFound)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < index; i++)
            {
                leftSum+= numbers[i];
            }

            for (int i = index + 1; i < numbers.Length; i++)
            {
                rightSum += numbers[i];
            }

            if (leftSum == rightSum)
            {
                isFound = true;
                Console.WriteLine(index);
            }
            else if (leftSum == 0 && rightSum == 0 && index + 1 == numbers.Length)
            {
                Console.WriteLine(0);
            }
            else if (numbers.Length == index + 1)
            {
                Console.WriteLine("no");
            }

            return isFound;
        }
    }
}
