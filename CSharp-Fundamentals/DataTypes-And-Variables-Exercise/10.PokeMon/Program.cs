namespace _10.PokeMon
{
    internal class Program
    {
        static void Main()
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int currPow = power;
            int targetCount = 0;

            while (currPow >= distance)
            {
                currPow -= distance;
                targetCount++;

                if ((decimal)power == (decimal)currPow * 2 && exhaustion != 0)
                {
                    currPow /= exhaustion;
                }
            }
            Console.WriteLine(currPow);
            Console.WriteLine(targetCount);
        }
    }
}