using System;

namespace _04.RefactoringPrimeChecker_ME
{
    internal class Program
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            for (int i = 2; i <= range; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLower());
            }

        }
    }
}
