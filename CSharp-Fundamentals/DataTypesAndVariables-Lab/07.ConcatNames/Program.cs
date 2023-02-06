using System;

namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine(String.Join(delimeter, firstName, secondName));
        }
    }
}
