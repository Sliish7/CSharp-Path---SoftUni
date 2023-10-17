namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main()
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            List<int> numbers = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                Predicate<int> isEven = i => i % 2 == 0;

                if (isEven(i) && command == "even")
                {
                    numbers.Add(i);
                }
                else if (!isEven(i) && command == "odd")
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}