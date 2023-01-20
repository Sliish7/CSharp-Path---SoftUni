using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double points = 0;
            double total = 0;

            if (num <= 100)
            {
                points += 5;

                if (num % 10 == 5)
                {
                    points += 2;
                }
                else if (num % 2 == 0)
                {
                    points += 1;
                }

                total = Convert.ToDouble(num) + points;
            }
            else if (num > 100 && num <= 1000)
            {
                points = Convert.ToDouble(num) * 0.20;

                if (num % 10 == 5)
                {
                    points += 2;
                }
                else if (num % 2 == 0)
                {
                    points += 1;
                }

                total = Convert.ToDouble(num) + points;
            }
            else
            {
                points = Convert.ToDouble(num) * 0.10;

                if (num % 10 == 5)
                {
                    points += 2;
                }
                else if (num % 2 == 0)
                {
                    points += 1;
                }

                total = Convert.ToDouble(num) + points;
            }

            Console.WriteLine(points);
            Console.WriteLine(total);
        }
    }
}
