using System;
using System.Reflection.Metadata;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lsPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            totalPrice += students * robePrice;
            //Every 6th belt is free.
            totalPrice += (students - (students / 6)) * beltPrice;
            //10% more lightsabers
            totalPrice += Math.Ceiling((students * 1.10)) * lsPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
                Console.WriteLine($"John will need {totalPrice - budget:f2}lv more.");
        }
    }
}
