using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string digit = num.ToString();
            int tot = 0;

            for (int i = 0; i < digit.Length; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= digit[i] - '0'; j++)
                {
                    factorial *= j;
                }
                tot += factorial;
            }

            if (tot == num)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
