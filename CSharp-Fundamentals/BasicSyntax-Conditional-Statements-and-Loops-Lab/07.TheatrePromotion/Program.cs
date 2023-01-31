using System;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main()
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 122)
            {
                switch (day)
                {
                    case "Weekday":
                        if (age <= 18)
                        {
                            Console.WriteLine("12$");
                        }
                        else if(age <= 64)
                        {
                            Console.WriteLine("18$");
                        }
                        else
                            Console.WriteLine("12$");
                        break;
                    case "Weekend":
                        if (age <= 18)
                        {
                            Console.WriteLine("15$");
                        }
                        else if (age <= 64)
                        {
                            Console.WriteLine("20$");
                        }
                        else
                            Console.WriteLine("15$");
                        break;
                    case "Holiday":
                        if (age <= 18)
                        {
                            Console.WriteLine("5$");
                        }
                        else if (age <= 64)
                        {
                            Console.WriteLine("12$");
                        }
                        else
                            Console.WriteLine("10$");
                        break;
                }
            }
            else
                Console.WriteLine("Error!");
        }
    }
}
