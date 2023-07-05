namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            MiddleChars();
        }

        private static string MiddleChars()
        {
            string input = Console.ReadLine();
            if (input.Length % 2 == 0)
            {
                Console.Write(input[input.Length / 2 - 1]);
            }
            Console.Write(input[input.Length / 2]);

            return input;
        }
    }
}