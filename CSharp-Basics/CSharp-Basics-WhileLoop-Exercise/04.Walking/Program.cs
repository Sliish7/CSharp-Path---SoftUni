using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main()
        {
            int goal = 10000;
            int totalSteps = 0;
            bool goalReached = false;

            while (goalReached != true)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    if (totalSteps >= goal)
                    {
                        goalReached = true;
                    }
                    break;
                }
                else
                totalSteps += Convert.ToInt32(input);

                if (totalSteps >= goal)
                {
                    goalReached = true;
                }
            }
            int difference = 0;

            if (goalReached == true)
            {
                difference = totalSteps - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }
            else
            {
                difference = goal - totalSteps;
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
        }
    }
}
