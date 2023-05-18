namespace _03.GamingStore
{
    internal class Program
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            double currBalance = balance;

            string game;

            while (currBalance >= 0)
            {
                game = Console.ReadLine();

                if (game == "Game Time")
                {
                    break;
                }

                double gamePrice = 0;

                switch (game)
                {
                    case "OutFall 4": gamePrice = 39.99;break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default:break;
                }

                if (gamePrice != 0)
                {
                    if (currBalance >= gamePrice)
                    {
                        Console.WriteLine($"Bought {game}");
                        currBalance -= gamePrice;
                    }
                    else
                        Console.WriteLine("Too Expensive");
                }
                else
                    Console.WriteLine("Not Found");
            }

            if (currBalance == 0.00)
            {
                Console.WriteLine("Out of money!");
            }
            else
                Console.WriteLine($"Total spent: ${Math.Abs(balance - currBalance):f2}. Remaining: ${currBalance:f2}");
        }
    }
}