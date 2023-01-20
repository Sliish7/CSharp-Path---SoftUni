using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int totalTime = first + second + third;
            int hours = totalTime / 3600;
            int min = totalTime / 60;
            int sec = totalTime % 60;

            if (min >= 60)
            {
                min = min - hours * 60;
                if (min < 10 && sec < 10)
                {
                    Console.WriteLine($"{hours}:0{min}:0{sec}");
                }
                else if (min < 10)
                {
                    Console.WriteLine($"{hours}:0{min}:{sec}");
                }
                else if (sec < 10)
                {
                    Console.WriteLine($"{hours}:{min}:0{sec}");
                }
                else
                {
                    Console.WriteLine($"{hours}:{min}:{sec}");
                }
            }
            else if (sec < 10)
            {      
                Console.WriteLine($"{min}:0{sec}");
            }
            else 
            {
                Console.WriteLine($"{min}:{sec}");
            }
            
        }
    }
}
