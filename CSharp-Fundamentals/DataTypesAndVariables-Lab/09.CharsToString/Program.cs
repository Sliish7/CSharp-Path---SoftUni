using System;

namespace _09.CharsToString
{
    internal class Program
    {
        static void Main()
        {
            string text = "";

            for (int i = 1; i <= 3; i++)
            {
                char input = char.Parse(Console.ReadLine());

                text += input.ToString();
            }

            Console.WriteLine(text);
        }
    }
}
