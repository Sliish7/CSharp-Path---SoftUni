namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(PalindromeIntegers(input));
                input = Console.ReadLine();
            }
        }

        private static bool PalindromeIntegers(string input)
        {
            bool isPalindrome = true;
            int number = int.Parse(input);
            char[] digits = number.ToString().ToCharArray();
            char[] reversed = new char[digits.Length];
            Array.Copy(digits, reversed, digits.Length);
            Array.Reverse(reversed);

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != reversed[i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}