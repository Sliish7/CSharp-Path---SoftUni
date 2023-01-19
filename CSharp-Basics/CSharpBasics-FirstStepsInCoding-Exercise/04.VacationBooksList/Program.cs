using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int hoursPerPage = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int hoursInTotal = pages / hoursPerPage;
            int hoursPerDay = hoursInTotal / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
