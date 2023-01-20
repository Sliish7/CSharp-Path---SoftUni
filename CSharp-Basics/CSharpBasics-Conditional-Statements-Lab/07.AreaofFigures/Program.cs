using System;

namespace _07.AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;

                Console.WriteLine($"{area:0.000}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                double area = a * b;

                Console.WriteLine($"{area:0.000}");
            }
            else if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double area = Math.PI * (a * a);

                Console.WriteLine($"{area:0.000}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b / 2;

                Console.WriteLine($"{area:0.000}");
            }
        }
    }
}
