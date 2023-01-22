using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main()
        {
            string flowerType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double discount = 0;
            double sumLeft = 0;
            double neededSum = 0;
            double total = 0;

            double rose = 5;
            double dahlia = 3.80;
            double tulip = 2.80;
            double narcissus = 3;
            double gladiolus = 2.50;

            switch (flowerType)
            {
                case "Roses":
                    if (quantity > 80)
                    {
                        discount = 0.10;
                        total = rose * quantity;
                        sumLeft = budget - (total - total * discount);
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(neededSum):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    else
                    {
                        total = rose * quantity;
                        sumLeft = budget - total;
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    break;
                case "Dahlias":
                    if (quantity > 90)
                    {
                        discount = 0.15;
                        total = dahlia * quantity;
                        sumLeft = budget - (total - total * discount);
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    else
                    {
                        sumLeft = budget - total;
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    break;
                case "Tulips":
                    if (quantity > 80)
                    {
                        discount = 0.15;
                        total = tulip * quantity;
                        sumLeft = budget - (total - total * discount);
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    else
                    {
                        sumLeft = budget - total;
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    break;
                case "Narcissus":
                    if (quantity < 120)
                    {
                        discount = 0.15;
                        total = narcissus * quantity;
                        sumLeft = budget - (total + total * discount);
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    else
                    {
                        total = narcissus * quantity;
                        sumLeft = budget - total;
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    break;
                case "Gladiolus":
                    if (quantity < 80)
                    {
                        discount = 0.20;
                        total = gladiolus * quantity;
                        sumLeft = budget - (total + total * discount);
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    else
                    {
                        sumLeft = budget - total;
                        if (sumLeft < 0)
                        {
                            Console.WriteLine($"Not enough money, you need {Math.Abs(sumLeft):f2} leva more.");
                        }
                        else
                        {
                            Console.WriteLine($"Hey, you have a great garden with {quantity} {flowerType} and {sumLeft:f2} leva left.");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
