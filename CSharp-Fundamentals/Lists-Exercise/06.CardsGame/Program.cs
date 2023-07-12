namespace _06.CardsGame
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                (firstPlayer, secondPlayer) = CardBattle(firstPlayer, secondPlayer);
            }

            if (firstPlayer.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {WinnerSum(firstPlayer)}");
            }
            else if (secondPlayer.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {WinnerSum(secondPlayer)}");
            }
            else
                Console.WriteLine("No player wins! Sum: 0");
        }

        private static (List<int> firstPlayer, List<int> secondPlayer) CardBattle(List<int> firstPlayer, List<int> secondPlayer)
        {
            int p1Card = firstPlayer[0];
            int p2Card = secondPlayer[0];

            if (p1Card > p2Card)
            {
                firstPlayer.Add(p2Card);
                firstPlayer.Add(p1Card);
            }
            else if (p2Card > p1Card)
            {
                secondPlayer.Add(p1Card);
                secondPlayer.Add(p2Card);
            }

            firstPlayer.RemoveAt(0);
            secondPlayer.RemoveAt(0);
            return (firstPlayer, secondPlayer);
        }
        private static int WinnerSum(List<int> list)
        {
            int sum = 0;
            foreach (int card in list)
            {
                sum += card;
            }
            return sum;
        }
    }
}