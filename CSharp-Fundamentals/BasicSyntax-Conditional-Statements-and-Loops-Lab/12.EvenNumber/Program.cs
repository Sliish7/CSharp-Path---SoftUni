using System;

namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isEven = false;

            while (!isEven)
            {
                n = Math.Abs(n);

                if (n % 2 == 0)
                {
                    isEven = true;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    n = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"The number is: {n}");
        }
    }
}
