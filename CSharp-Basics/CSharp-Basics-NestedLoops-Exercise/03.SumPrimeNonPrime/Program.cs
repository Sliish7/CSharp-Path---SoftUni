using System;
using System.Transactions;
using System.Xml;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int notPrimeSum = 0;

            while (input != "stop")
            {
                int currNum = int.Parse(input);
                bool isPrime = true;

                if (currNum < 0)
                {
                    Console.WriteLine($"Number is negative.");
                }
                else
                {
                    if (currNum <= 1)
                    {
                        isPrime = false;
                    }
                    else if (currNum == 2)
                    {
                        isPrime = true;
                    }
                    else if (currNum % 2 == 0)
                    {
                        isPrime = false;
                    }

                    int boundary = (int)Math.Floor(Math.Sqrt(currNum));

                    for (int i = 3; i <= boundary; i++)
                    {
                        if (currNum % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        primeSum += currNum;
                    }
                    else
                        notPrimeSum += currNum;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");
        }
    }
}
