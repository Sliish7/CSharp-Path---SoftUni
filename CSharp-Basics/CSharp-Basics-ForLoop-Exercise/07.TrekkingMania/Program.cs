using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main()
        {
            int groups = int.Parse(Console.ReadLine());
            int people = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < groups; i++)
            {
                int groupsize = int.Parse(Console.ReadLine());

                if (groupsize >= 41)
                {
                    p5 += groupsize;
                }
                else if (groupsize >= 26)
                {
                    p4 += groupsize;
                }
                else if (groupsize >= 13)
                {
                    p3 += groupsize;
                }
                else if (groupsize >= 6)
                {
                    p2 += groupsize;
                }
                else
                    p1 += groupsize;

                people += groupsize;
            }
            p1 = p1 / people * 100;
            p2 = p2 / people * 100;
            p3 = p3 / people * 100;
            p4 = p4 / people * 100;
            p5 = p5 / people * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
