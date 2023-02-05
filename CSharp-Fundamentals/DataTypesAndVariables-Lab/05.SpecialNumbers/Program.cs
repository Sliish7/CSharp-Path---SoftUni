using System;
using System.Security.Cryptography;
using System.Transactions;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int numRange = n;


            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = false;
                int sumOfDigits = 0;

                string currNum = i.ToString();
                for (int j = 0; j < currNum.Length; j++)
                {
                    char currDigit = currNum[j];
                    int digit = currDigit - '0';
                    sumOfDigits+= digit;
                }

                if (sumOfDigits == 7 || sumOfDigits == 11 || sumOfDigits == 5)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
                sumOfDigits = 0;

            }
        }
    }
}
