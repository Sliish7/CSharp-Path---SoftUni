using System;

namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            double daysPerYear = 365.2422;
            double days = Math.Floor(centuries * 100 * daysPerYear);
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {centuries * 100} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
