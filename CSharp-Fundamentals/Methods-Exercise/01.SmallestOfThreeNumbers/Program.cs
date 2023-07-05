namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SmallestOfThreeNumbers());
        }

        private static int SmallestOfThreeNumbers()
        {
            int minNumber = int.MaxValue;

            for (int i = 0; i < 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            return minNumber;
        }
    }
}