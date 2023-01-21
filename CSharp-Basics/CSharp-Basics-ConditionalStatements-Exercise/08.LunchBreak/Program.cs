using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int minPerEp = int.Parse(Console.ReadLine());
            int freetime = int.Parse(Console.ReadLine());

            double lunchBreak = freetime * 0.125;
            double otherBreak = freetime * 0.25;
            double timeLeft = freetime - (lunchBreak + otherBreak);

            if (timeLeft >= minPerEp)
            {
                double minLeft = Math.Ceiling(timeLeft - minPerEp);
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {minLeft} minutes free time.");
            }
            else
            {
                double minNeeded = Math.Ceiling(minPerEp - timeLeft);
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {minNeeded} more minutes.");
            }
        }
    }
}