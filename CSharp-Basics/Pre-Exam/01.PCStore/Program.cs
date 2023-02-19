using System;

namespace _01.PCStore
{
    internal class Program
    {
        static void Main()
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            double quantityRam = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            cpuPrice *= 1.57;
            gpuPrice *= 1.57;
            ramPrice = (ramPrice * 1.57) * quantityRam;
            cpuPrice -= cpuPrice * discount; gpuPrice -= gpuPrice* discount;

            double totalPrice = cpuPrice + gpuPrice + ramPrice;

            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");
        }
    }
}
