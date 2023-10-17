namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> numbers = new();

            Func<int, int[], List<int>> calculate = (range, dividers) =>
            {
                List<int> result = new();

                for (int i = 1; i <= range; i++)
                {
                    int currNumber = i;

                    if (dividers.All(x => currNumber % x == 0))
                    {
                        result.Add(currNumber);
                    }
                }
                return result;
            };

            numbers = calculate(range, dividers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}