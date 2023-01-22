using System;
using System.Numerics;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;
            string oddOrEven = "";

            if (n2 == 0 && (symbol == "/" || symbol == "%"))
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else
            {
                switch (symbol)
                {
                    case "+":
                        result = n1 + n2;
                        break;
                    case "-":
                        result = n1 - n2;
                        break;
                    case "/":
                        result = (double)n1 / (double)n2;
                        break;
                    case "*":
                        result = n1 * n2;
                        break;
                    case "%":
                        result = n1 % n2;
                        break;
                    default:
                        break;
                }

                if (result % 2 == 0 && symbol != "%" && symbol != "/")
                {
                    oddOrEven = "even";
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - {oddOrEven}");
                }
                else if (result % 2 != 0 && symbol != "%" && symbol != "/")
                {
                    oddOrEven = "odd";
                    Console.WriteLine($"{n1} {symbol} {n2} = {result} - {oddOrEven}");
                }
                else
                {
                    if (symbol == "/")
                    {
                        Console.WriteLine($"{n1} {symbol} {n2} = {result:f2}");
                    }
                    else
                        Console.WriteLine($"{n1} {symbol} {n2} = {result}");
                }
            }
        }
    }
}
