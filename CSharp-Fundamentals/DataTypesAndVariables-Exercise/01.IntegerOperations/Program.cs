using System;

namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main()
        {
            int result = 0;

            for (int i = 1; i <= 4; i++)
            {
                int num = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1: case 2: result += num; break;
                    case 3: result /= num; break;
                    case 4: result *= num; break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
