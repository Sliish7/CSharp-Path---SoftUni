using System;

namespace _07._FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veggieMenu = int.Parse(Console.ReadLine());
            double menusPrice = chickenMenus * 10.35 + fishMenus * 12.40 + veggieMenu * 8.15;
            double dessert = menusPrice * 0.20;
            double deliveryTax = 2.50;

            Console.WriteLine(menusPrice + dessert + deliveryTax);
        }
    }
}
