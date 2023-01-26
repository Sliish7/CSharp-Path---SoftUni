using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main()
        {
            int badScore = int.Parse(Console.ReadLine());
            string nameProblem = Console.ReadLine();
            int score = int.Parse(Console.ReadLine());
            int problemCounter = 0;
            int totalScores = 0;
            int badScoresCount = 0;
            string lastProblem = "";

            while (nameProblem != "Enough")
            {
                problemCounter++;
                totalScores += score;

                if (score <= 4)
                {
                    badScoresCount++;
                    if (badScoresCount == badScore)
                    {
                        Console.WriteLine($"You need a break, {badScore} poor grades.");
                        break;
                    }
                }

                nameProblem = Console.ReadLine();
                if (nameProblem == "Enough")
                {
                    break;
                }
                else
                    lastProblem = nameProblem;
                score = int.Parse(Console.ReadLine()); 
            }

            double avg = (double)totalScores / problemCounter;
            if (badScoresCount != badScore)
            {
                Console.WriteLine($"Average score: {avg:f2}");
                Console.WriteLine($"Number of problems: {problemCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
