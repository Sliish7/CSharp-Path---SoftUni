using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int col = 1; col <= num; col++)
            {
                for (int row = 1; row <= col; row++)
                {
                    if (counter > num)
                    {
                        break;
                    }
                    Console.Write($"{counter} ");
                    counter++;
                }
                if (counter > num)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
