using System.Xml;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            TopNumber(length);
        }

        private static int TopNumber(int length)
        {
            int topNumber = 0;

            for (int i = 1; i <= length; i++)
            {
                int currNum = i;
                char[] digits = currNum.ToString().ToCharArray();

                if (OddDigit(digits) && isDivisible(digits))
                {
                    Console.WriteLine(currNum);
                }
            }
            
            return topNumber;
        }

        private static bool isDivisible(char[] digits)
        {
            bool isDivisible = false;
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }

            if (sum % 8 == 0)
            {
                isDivisible = true;
            }
            return isDivisible;
        }

        private static bool OddDigit(char[] digits)
        {
            bool isOdd = false;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
            }

            return isOdd;
        }
    }
}