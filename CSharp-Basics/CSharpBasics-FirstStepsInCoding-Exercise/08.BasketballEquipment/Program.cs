using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyPrice = int.Parse(Console.ReadLine());
            double bootsPrice = yearlyPrice - yearlyPrice * 0.40;
            double equipmentPrice = bootsPrice - bootsPrice * 0.20;
            double ballPrice = equipmentPrice * 0.25;
            double stuffs = ballPrice * 0.20;

            double total = yearlyPrice + bootsPrice + equipmentPrice + ballPrice + stuffs;

            Console.WriteLine(total);

        }
    }
}
