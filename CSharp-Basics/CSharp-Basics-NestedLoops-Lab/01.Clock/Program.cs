using System;

namespace _01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hh = 0; hh < 24; hh++)
            {
                for (int mm = 0; mm < 60; mm++)
                {
                    Console.WriteLine($"{hh}:{mm}");
                }
            }
        }
    }
}
