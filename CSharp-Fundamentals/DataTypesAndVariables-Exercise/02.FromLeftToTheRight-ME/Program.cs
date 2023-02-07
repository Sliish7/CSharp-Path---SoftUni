using System;
using System.Numerics;

namespace _02.FromLeftToTheRight_ME
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            string currNum;

            for (int i = 1; i <= input; i++)
            {
                string nums = Console.ReadLine();
                string[] numbers = nums.Split(' ');
                BigInteger num1 = BigInteger.Parse(numbers[0]);
                BigInteger num2 = BigInteger.Parse(numbers[1]);

                if (num1 > num2)
                {
                    currNum = Math.Abs((decimal)num1).ToString();
                    result = Result(currNum, result);
                    Console.WriteLine(result);

                }
                else 
                {
                    currNum = Math.Abs((decimal)num2).ToString();
                    result = Result(currNum, result);
                    Console.WriteLine(result);
                }
                result= 0;
            }
        }

        static int Result(string currNum, int result)
        {
            for (int i = 0; i < currNum.Length; i++)
            {
                int digit = currNum[i] - '0';
                result += digit;

            }
            return result;
        }
    }
}
