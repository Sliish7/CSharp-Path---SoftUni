using System;
using System.Transactions;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i < 10000; i++)
            {
                string currNum = i.ToString();
                bool luckyNum = false;
                for (int j = 0; j < currNum.Length; j++)
                {
                    int digit = currNum[j] - '0';
                    if (digit == 0)
                    {
                        luckyNum = false;
                        break;
                    }
                    else if (n % digit == 0)
                    {
                        luckyNum = true;
                    }
                    else
                    {
                        luckyNum = false;
                        break;
                    }
                }

                if (luckyNum) { Console.Write($"{i} "); }
            }
        }
    }
}
