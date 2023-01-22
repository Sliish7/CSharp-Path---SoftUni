using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double discount = 0;
            double total = 0;

            switch (town)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        discount = 0.05;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        discount = 0.07;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        discount = 0.08;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 10000)
                    {
                        discount = 0.12; ;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        discount = 0.045;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        discount = 0.075;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        discount = 0.10;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 10000)
                    {
                        discount = 0.13;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        discount = 0.055;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        discount = 0.08;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        discount = 0.12;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else if (sales > 10000)
                    {
                        discount = 0.145;
                        total = sales * discount;
                        Console.WriteLine($"{total:f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
