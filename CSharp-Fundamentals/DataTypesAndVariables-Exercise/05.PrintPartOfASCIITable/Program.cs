using System;

namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main()
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int i = startChar; i <= endChar; i++)
            {
                char currChar = Convert.ToChar(i);
                Console.Write(" {0}",currChar);
            }
        }
    }
}
