using System;

namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main()
        {
            char letter = char.Parse(Console.ReadLine());
            int asciiCode = letter;

            if (asciiCode < 97)
            {
                Console.WriteLine("upper-case");
            }
            else
                Console.WriteLine("lower-case");

            //char letter = char.Parse(Console.ReadLine());
            //if (char.IsLower(letter))
            //{
            //    Console.WriteLine("lower-case");
            //}
            //else if (char.IsUpper(letter))
            //{
            //    Console.WriteLine("upper-case");
            //}
        }
    }
}
