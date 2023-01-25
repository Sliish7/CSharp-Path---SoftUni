using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gradeCount = 0;
            int badYearGrade = 0;
            double avgGrade = 0;
            bool stop = false;

            while (stop == false)
            {
                double currGrade = double.Parse(Console.ReadLine());
                if (currGrade < 4.00)
                {
                    badYearGrade++;
                }

                avgGrade += currGrade;
                gradeCount++;

                if (badYearGrade == 2 || gradeCount == 12)
                {
                    stop = true;
                }
            }

            if (badYearGrade == 2)
            {
                Console.WriteLine($"{name} has been excluded at {gradeCount - 1} grade");
            }
            else
            {
                avgGrade = avgGrade / gradeCount;
                Console.WriteLine($"{name} graduated. Average grade: {avgGrade:f2}");
            }
        }
    }
}
