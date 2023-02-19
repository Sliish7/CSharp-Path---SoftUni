using System;
using System.Globalization;

namespace _06.MultiplyTable
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int firstDig = number / 100;
            int secondDig = (number / 10) % 10;
            int thirdDig = number % 10;

            for (int i = 1; i <= thirdDig; i++)
            {
                for (int j = 1; j <= secondDig; j++)
                {
                    for (int n = 1; n <= firstDig; n++)
                    {
                        int result = i * j * n;
                        Console.WriteLine($"{i} * {j} * {n} = {result};");
                    }
                }
            }
            
        }
    }
}
