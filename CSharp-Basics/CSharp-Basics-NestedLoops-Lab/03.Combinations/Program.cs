using System;

namespace _03.Combinations
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int x = 0; x <= input; x++)
            {
                for (int y = 0; y <= input; y++)
                {
                    for (int z = 0; z <= input; z++)
                    {
                        if (x + y + z == input)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
