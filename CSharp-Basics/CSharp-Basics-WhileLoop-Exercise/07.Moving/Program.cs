using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int cbMeters = width* height * length;

            while (cbMeters >= 0)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                cbMeters -= Convert.ToInt32(input);
            }

            if (cbMeters < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(cbMeters)} Cubic meters more.");
            }
            else
                Console.WriteLine($"{cbMeters} Cubic meters left.");
        }
    }
}
