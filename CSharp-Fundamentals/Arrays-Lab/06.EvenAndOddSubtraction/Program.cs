using System;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            int sumOdd = 0;
            int sumEven = 0;

            foreach (var number in numbers)
            {
                int currNum = int.Parse(number);

                if (currNum % 2 == 0)
                {
                    sumEven += currNum;
                }
                else
                    sumOdd+= currNum;
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}
