using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int timeframe = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double sum = deposit + timeframe * ((deposit * (interest / 100)) / 12);
            Console.WriteLine(sum);
        }
    }
}
