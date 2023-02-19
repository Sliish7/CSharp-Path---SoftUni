using System;

namespace _04.Exam
{
    internal class Program
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            double topStudents = 0;
            // < 4.99
            double group2 = 0;
            // < 3,99
            double group3 = 0;
            // < 3.00
            double worstStudents = 0;
            double avgGrade = 0;

            for (int i = 1; i <= students; i++)
            {
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentGrade < 3.00)
                {
                    worstStudents++;
                }
                else if (studentGrade < 3.99)
                {
                    group3++;
                }
                else if (studentGrade < 4.99)
                {
                    group2++;
                }
                else
                    topStudents++;
                avgGrade += studentGrade;
            }

            topStudents = topStudents / students * 100;
            group2= group2 / students * 100;
            group3= group3 / students * 100;
            worstStudents = worstStudents/ students * 100;
            avgGrade /= students;

            Console.WriteLine($"Top students: {topStudents:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {group2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {group3:f2}%");
            Console.WriteLine($"Fail: {worstStudents:f2}%");
            Console.WriteLine($"Average: {avgGrade:f2}");

        }
    }
}
