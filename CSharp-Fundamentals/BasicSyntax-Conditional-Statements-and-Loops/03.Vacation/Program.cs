using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double totalPrice = 0;
            double price = 0;

            switch (type)
            {
                case "Students":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 9.80;
                    }
                    else
                        price = 10.46;

                    totalPrice = price * people;
                    if (people >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 15.60;
                    }
                    else
                        price = 16;

                    if (people >= 100)
                    {
                        totalPrice = price * (people - 10);
                    }
                    else
                        totalPrice = price * people;

                    break;
                case "Regular":
                    if (dayOfTheWeek == "Friday")
                    {
                        price = 15;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 20;
                    }
                    else
                        price = 22.50;

                    totalPrice = price * people;
                    if (people >= 10 && people <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
