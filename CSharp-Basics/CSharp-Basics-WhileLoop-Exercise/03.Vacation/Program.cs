using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main()
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int daysSpendCounter = 0;
            bool isFailed = false;

            string result = "";

            while (money < moneyNeeded)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                daysCounter++;
                switch (action)
                {
                    case "spend": money -= amount; daysSpendCounter++;
                        if (money < 0)
                        {
                            money = 0;
                        }
                        break;
                    case "save": money += amount; daysSpendCounter = 0; break;
                }
                if (daysSpendCounter == 5)
                {
                    result = $@"You can't save the money." + "\n" + $@"{daysCounter}";
                    isFailed = true;
                    break;
                }
            }

            if (!isFailed)
            {
                result = $@"You saved the money for {daysCounter} days.";
                Console.WriteLine(result);
            }
            else
                Console.WriteLine(result);
        }
    }
}
