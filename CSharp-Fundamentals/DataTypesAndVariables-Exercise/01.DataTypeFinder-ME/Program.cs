using System;

namespace _01.DataTypeFinder_ME
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int valueInt;
            float valueFloat;
            bool valueBoolean;
            char valueChar;

            while (input != "END")
            {
                if (int.TryParse(input, out valueInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out valueFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (Boolean.TryParse(input, out valueBoolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out valueChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                    Console.WriteLine($"{input} is string type");
                input= Console.ReadLine();
            }
        }
    }
}
