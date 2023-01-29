using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main()
        {
            int judges = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int subjectCount = 0;
            double finalAsess = 0;
            while (input != "Finish")
            {        
                double avgGrade = 0;
                for (int i = 1; i <= judges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    avgGrade += grade;
                }
                avgGrade /= judges;
                subjectCount++;
                finalAsess += avgGrade;

                Console.WriteLine($"{input} - {avgGrade:f2}.");
                input = Console.ReadLine();
            }
            finalAsess /= subjectCount;
            Console.WriteLine($"Student's final assessment is {finalAsess:f2}.");
        }
    }
}
