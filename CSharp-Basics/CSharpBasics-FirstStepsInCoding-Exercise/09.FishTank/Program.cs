using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int v = lenght * width * height;
            double vInlitres = v * 0.001;

            double litresNeeded = vInlitres * (1 - percent / 100);

            Console.WriteLine(litresNeeded);
        }
    }
}
