using System;
using System.Transactions;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double expences = 0;
            int trashKBcount = 0;

            double headsetPr = double.Parse(Console.ReadLine());
            double mousePr = double.Parse(Console.ReadLine());
            double keyboardPr = double.Parse(Console.ReadLine());
            double displayPr = double.Parse(Console.ReadLine());

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    expences += mousePr + headsetPr + keyboardPr;
                    trashKBcount++;
                }
                else if (i % 2 == 0)
                {
                    expences += headsetPr;
                }
                else if (i % 3 == 0)
                {
                    expences += mousePr;
                }

                if (trashKBcount % 2 == 0 && trashKBcount != 0)
                {
                    trashKBcount = 0;
                    expences += displayPr;
                }
            }

            Console.WriteLine($"Rage expenses: {expences:f2} lv.");
        }
    }
}
