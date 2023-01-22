using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main()
        {
            int time = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    if (time >= 10 && time <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Tuesday":
                    if (time >= 10 && time <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Wednesday":
                    if (time >= 10 && time <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Thursday":
                    if (time >= 10 && time <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Friday":
                    if (time >= 10 && time <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Saturday":
                    if (time >= 10 && time <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
                default:
                    break;
            }
        }
    }

}
