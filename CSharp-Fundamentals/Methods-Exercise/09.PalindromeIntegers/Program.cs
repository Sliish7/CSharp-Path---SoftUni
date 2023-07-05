namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = { 2, 3, 4, 5, 6 };
            int[] arr2 = new int[arr.Length];
            Array.Copy(arr, arr2, arr.Length);
            Array.Reverse(arr2);

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
                else
                    isPalindrome= true;
            }

            return isPalindrome;
        }
    }
}