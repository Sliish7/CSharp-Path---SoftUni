using System;

namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMinutes = hours * 60 + minutes + 30;

            int finalM = totalMinutes % 60;
            int finalH = (totalMinutes - finalM) / 60;

            if (finalM < 10)
            {
                if (finalH > 23)
                {
                    finalH -= 24;
                    Console.WriteLine($"{finalH}:0{finalM}");
                }
                else
                    Console.WriteLine($"{finalH}:0{finalM}");
            }
            else
            {
                if (finalH > 23)
                {
                    finalH -= 24;
                    Console.WriteLine($"{finalH}:{finalM}");
                }
                else
                    Console.WriteLine($"{finalH}:{finalM}");
            }
        }
    }
}
