using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (product)
                    {
                        case "banana":
                            price = 2.50;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}"); break;
                        case "apple":
                            price = 1.20;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}"); break;
                        case "orange":
                            price = 0.85;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}"); break;
                        case "grapefruit":
                            price = 1.45;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}"); break;
                        case "kiwi":
                            price = 2.70;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "pineapple":
                            price = 5.50;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "grapes":
                            price = 3.85;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (product)
                    {
                        case "banana":
                            price = 2.70;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "apple":
                            price = 1.25;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "orange":
                            price = 0.90;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "grapefruit":
                            price = 1.60;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "kiwi":
                            price = 3.00;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "pineapple":
                            price = 5.60;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        case "grapes":
                            price = 4.20;
                            total = price * quantity;
                            Console.WriteLine($"{total:f2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
            break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
