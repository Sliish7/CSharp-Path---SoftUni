using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int lowest = int.MaxValue;
            int highest = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < lowest)
                {
                    lowest = num;
                }
                if (num > highest)
                {
                    highest = num;
                }

            }
            Console.WriteLine($"Max number: {highest}");
            Console.WriteLine($"Min number: {lowest}");
        }
    }
}
