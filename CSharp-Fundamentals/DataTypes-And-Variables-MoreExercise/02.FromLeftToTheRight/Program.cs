using System.Numerics;

namespace _02.FromLeftToTheRight
{
    internal class Program
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());            

            for (int i = 0; i < numbers; i++)
            {
                int sum = 0;
                string[] currNum = Console.ReadLine().Split(" ");

                BigInteger num1 = BigInteger.Parse(currNum[0]);
                BigInteger num2 = BigInteger.Parse(currNum[1]);

                if (num1 > num2)
                {
                    num1 = BigInteger.Abs(num1);
                    while (num1 > 0)
                    {
                        BigInteger digit = num1 % 10;
                        sum += (int)digit;
                        num1 /= 10;
                    }
                }
                else
                {
                    num2 = BigInteger.Abs(num2);
                    while (num2 > 0)
                    {
                        BigInteger digit = num2 % 10;
                        sum += (int)digit;
                        num2 /= 10;
                    }
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}