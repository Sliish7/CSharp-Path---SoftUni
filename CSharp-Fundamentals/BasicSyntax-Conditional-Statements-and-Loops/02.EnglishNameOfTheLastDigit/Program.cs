using System;
using System.Net.Mime;

namespace _02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string numAsStr = num.ToString();

            for (int i = numAsStr.Length - 1; i < numAsStr.Length; i++)
            {
                char digit = (char)numAsStr[i];
                int intDigit = digit - '0';
                string output = Spelling(intDigit);
                Console.WriteLine(output);
            }
        }

        static string Spelling(int intDigit)
        {
            return intDigit switch
            {
                0 => "zero",
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                _ => "",
            };
        }
    }
}
