using System;
using System.Data.SqlTypes;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int qGpus = int.Parse(Console.ReadLine());
            int qCpus = int.Parse(Console.ReadLine());
            int qRam = int.Parse(Console.ReadLine());

            double discount = 0;
            double totalPrice = 0;

            double gpuPrice = qGpus * 250;
            double cpuPrice = (gpuPrice * 0.35) * qCpus;
            double ramPrice = (gpuPrice * 0.10) * qRam;

            if (qGpus > qCpus)
            {
                discount = 0.15;
                totalPrice = gpuPrice + cpuPrice + ramPrice;
                totalPrice -= totalPrice * discount;
            }
            else
            {
                totalPrice = gpuPrice + cpuPrice + ramPrice;
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"You have {moneyLeft:0.00} leva left!");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:0.00} leva more!");
            }
        }
    }
}
