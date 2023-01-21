using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secPerMet = double.Parse(Console.ReadLine());
            
            double seconds = meters * secPerMet;
            double bonusTime = Math.Floor(meters / 15) * 12.5;
            seconds += bonusTime;

            if (seconds < recordSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {seconds:0.00} seconds.");
            }
            else
            {
                double secSlower = seconds - recordSeconds;
                Console.WriteLine($"No, he failed! He was {secSlower:0.00} seconds slower.");
            }
        }
    }
}
