using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int coursesNeeded = 0;

            while (people > 0)
            {
                people -= capacity;
                coursesNeeded++;
            }
            Console.WriteLine(coursesNeeded);
        }
    }
}
