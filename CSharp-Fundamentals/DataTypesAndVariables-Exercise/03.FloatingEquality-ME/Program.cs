using System;

namespace _03.FloatingEquality_ME
{
    internal class Program
    {
        static void Main()
        {
            double eps = 0.000001;
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double difference = Math.Abs(num1 - num2);
            bool isValid = difference < eps ? isValid = true : isValid = false;
            Console.WriteLine(isValid);
        }
    }
}
