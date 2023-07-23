namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        private static bool IsValid(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            bool isValidName = username.All(x => char.IsLetterOrDigit(x) || x == '-' || x == '_');


            return isValidName;
        }
    }
}