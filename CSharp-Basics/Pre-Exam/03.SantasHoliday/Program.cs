using System;

namespace _03.SantasHoliday
{
    internal class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            int nights = days - 1;
            double totalPrice = 0;

            switch (room)
            {
                case "room for one person":
                    double pricePerNight = 18;
                    totalPrice = pricePerNight * nights;

                    break;
                case "apartment":
                    pricePerNight = 25;
                    totalPrice = pricePerNight * nights;

                    if (days > 15)
                    {
                        totalPrice -= totalPrice * 0.50;
                    }
                    else if (days >= 10)
                    {
                        totalPrice -= totalPrice * 0.35;
                    }
                    else
                        totalPrice -= totalPrice * 0.30;

                    break;
                case "president apartment":
                    pricePerNight= 35;
                    totalPrice = pricePerNight * nights;

                    if (days > 15)
                    {
                        totalPrice -= totalPrice * 0.20;
                    }
                    else if (days >= 10)
                    {
                        totalPrice -= totalPrice * 0.20;
                    }
                    else
                        totalPrice -= totalPrice * 0.10;

                    break;
            }

            if (rating == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else
                totalPrice -= totalPrice * 0.10;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
