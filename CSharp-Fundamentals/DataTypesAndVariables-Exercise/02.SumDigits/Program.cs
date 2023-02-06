using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            string numberAsStr = number.ToString();

            for (int i = 0; i < numberAsStr.Length; i++)
            {
                int digit = numberAsStr[i] - '0';
                result += digit;
            }
            Console.WriteLine(result);
        }
    }
}
