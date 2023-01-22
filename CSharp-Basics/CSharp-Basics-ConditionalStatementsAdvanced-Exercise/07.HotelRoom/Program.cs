using System;
using System.Threading;
using System.Xml.Schema;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            double totalPriceSt = 0;
            double totalPriceAp = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if (days > 14)
                {
                    studioPrice *= 0.70;
                    apartmentPrice *= 0.90;
                }
                else if(days > 7)
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (days > 14)
                {
                    studioPrice *= 0.80;
                    apartmentPrice *= 0.90;
                }
            }
            else
            {
                studioPrice = 76;
                apartmentPrice = 77;

                if (days > 14)
                {
                    apartmentPrice *= 0.90;
                }
            }

            totalPriceAp = apartmentPrice * days;
            totalPriceSt = studioPrice * days;

            Console.WriteLine($"Apartment: {totalPriceAp:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceSt:f2} lv.");
        }
    }
}
