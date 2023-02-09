using System;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            foreach (string element in input)
            {
                double currNum = double.Parse(element);
                

                string result = $"{currNum} => {Math.Round(currNum, MidpointRounding.AwayFromZero)}";
                Console.WriteLine(result);
            }
        }
    }
}
