using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sqMeters = double.Parse(Console.ReadLine());

            double discount = (sqMeters * 7.61) * 0.18;
            double finalPrice = (sqMeters * 7.61) - discount;

            Console.WriteLine($"The final price is: {finalPrice:0.00} lv. \nThe discount is: {discount:0.00} lv.");
        }
    }
}
