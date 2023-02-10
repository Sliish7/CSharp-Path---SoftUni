using System;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            int sum = 0;

            foreach (var number in numbers)
            {
                int currNum = int.Parse(number);

                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
