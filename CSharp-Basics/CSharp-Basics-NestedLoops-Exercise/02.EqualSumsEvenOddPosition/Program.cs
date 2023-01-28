using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2 ; i++)
            {
                string currNum = i.ToString();
                int odd = 0;
                int even = 0;

                for (int j = 0; j < currNum.Length; j++)
                {
                    int currDigit = int.Parse(currNum[j].ToString());

                    if (j % 2 == 0)
                    {
                        even += currDigit;
                    }
                    else
                        odd += currDigit;
                }

                if (odd == even)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
