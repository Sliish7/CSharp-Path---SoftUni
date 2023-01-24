using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double productPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysCount = 0;
            int moneyPerYear = 10;
            double moneySaved = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved += moneyPerYear;
                    moneyPerYear += 10;
                    moneySaved--;
                }
                else
                    toysCount++;
            }
            moneySaved += toysCount * toyPrice;

            if (moneySaved >= productPrice)
            {
                double moneyLeft = moneySaved - productPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = productPrice - moneySaved;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
