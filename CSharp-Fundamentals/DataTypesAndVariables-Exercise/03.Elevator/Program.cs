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

            if (coursesNeeded == 1)
            {
                Console.WriteLine("All the persons fit inside in the elevator.\nOnly one course is needed.");
            }
            else
                Console.WriteLine(coursesNeeded);
        }
    }
}
