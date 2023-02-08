using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            string[] days = {"Invalid day!","Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (0 < day && days.Length > day)
            {
                Console.WriteLine(days[day]);
            }
            else
                Console.WriteLine(days[0]);
        }
    }
}
