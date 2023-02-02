using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string guess = Console.ReadLine();
            int tries = 0;
            while (guess != password)
            {
                tries ++;
                if (tries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                    Console.WriteLine("Incorrect password. Try again.");

                guess = Console.ReadLine();
            }

            if (tries != 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
