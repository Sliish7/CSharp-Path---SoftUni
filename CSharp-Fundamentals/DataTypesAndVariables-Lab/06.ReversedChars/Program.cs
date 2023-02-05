using System;

namespace _06.ReversedChars
{
    internal class Program
    {
        static void Main()
        {
            string[] arr = new string[3];

            for (int i = 0; i < 3; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Array.Reverse(arr);

            foreach (string el in arr)
            {
                Console.Write($"{el} ");
            }
        }
    }
}
