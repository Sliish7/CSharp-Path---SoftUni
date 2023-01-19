using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogsFood = int.Parse(Console.ReadLine());
            int catsFood = int.Parse(Console.ReadLine());

            double price = dogsFood * 2.5 + catsFood * 4;
            Console.WriteLine($"{price} lv.");
        }
    }
}
