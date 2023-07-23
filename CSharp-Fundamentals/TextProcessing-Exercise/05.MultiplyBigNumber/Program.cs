using System.Numerics;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main()
        {
            string bigNum = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());

            int carry = 0;
            string output = string.Empty;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                if (digit == 0)
                {
                    output = "0";
                    break;
                }

                int currDigit = (int)bigNum[i] - '0';
                int currResult = currDigit * digit + carry;

                carry = currResult / 10;
                output += currResult % 10;

                if (i == 0 && carry != 0)
                {
                    output += carry;
                }
            }
            char[] charArray = output.ToCharArray();
            Array.Reverse( charArray );
            Console.WriteLine(charArray);
        }
    }
}