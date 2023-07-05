using System.Xml;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                char[] input = Console.ReadLine().ToCharArray();
                Console.WriteLine(PasswordValidator(input));
            }
        }

        private static string PasswordValidator(char[] input)
        {
            string output = string.Empty;
            int digitCount = 0;
            int charCount = 0;
            bool isSpecialChars = false;
            bool isValid = true; ;

            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                {

                }
                else if (Char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                    isSpecialChars = true;
            
                charCount++;
            }

            if (charCount < 6 || charCount > 10) 
            { output += "Password must be between 6 and 10 characters\n"; isValid = false; }
            if (isSpecialChars)
            {output += "Password must consist only of letters and digits\n"; isValid = false; }
            if (digitCount < 2)
            { output += "Password must have at least 2 digits"; isValid = false; }

            if (isValid)
            {
                output = "Password is valid";
            }
            return output; 
        }
    }
}