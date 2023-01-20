using System;

namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pw = Console.ReadLine();
            string pwToGuess = "s3cr3t!P@ssw0rd";

            if (pw == pwToGuess)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
