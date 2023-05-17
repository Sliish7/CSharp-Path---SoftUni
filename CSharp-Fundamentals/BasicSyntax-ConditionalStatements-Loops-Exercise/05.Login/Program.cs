namespace _05.Login
{
    internal class Program
    {
        static void Main()
        {
            string user = Console.ReadLine();

            char[] strArray = user.ToCharArray();
            Array.Reverse(strArray);
            string password = new(strArray);

            for (int i = 1; i <= 4; i++)
            {
                string input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else
                {
                    if ( i == 4)
                    {
                        Console.WriteLine($"User {user} blocked!");
                    }
                    else
                        Console.WriteLine("Incorrect password. Try again.");
                }
            }

        }
    }
}