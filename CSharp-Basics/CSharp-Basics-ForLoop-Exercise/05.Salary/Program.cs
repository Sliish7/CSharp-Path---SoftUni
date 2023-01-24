using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fine = 0;

            for (int i = 0; i < tabs; i++)
            {
                string tab = Console.ReadLine();

                switch (tab)
                {
                    case "Facebook":
                        fine += 150;
                        break;
                    case "Instagram":
                        fine += 100;
                        break;
                    case "Reddit":
                        fine += 50;
                        break;
                    default:
                        break;
                }

                if (fine >= salary)
                {
                    i = tabs;
                }
            }

            if (salary > fine)
            {
                Console.WriteLine(salary - fine);
            }
            else
                Console.WriteLine("You have lost your salary.");
        }
    }
}
