using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p1count = 0;
            int p2count = 0;
            int p3count = 0;
            int p4count = 0;
            int p5count = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 800)
                {
                    p5count++;
                }
                else if (num >= 600)
                {
                    p4count++;
                }
                else if (num >= 400)
                {
                    p3count++;
                }
                else if (num >= 200)
                {
                    p2count++;
                }
                else
                    p1count++;
            }

            double p1 = (double)p1count / (double)n * 100;
            double p2 = (double)p2count / (double)n * 100;
            double p3 = (double)p3count / (double)n * 100;
            double p4 = (double)p4count / (double)n * 100;
            double p5 = (double)p5count / (double)n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
