using System.Reflection;

namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> reverse = (numbers) =>
            {
                List<int> result = new List<int>(numbers);
                result.Reverse();

                return result;
            };

            Func<List<int>, int, List<int>> exclude = (numbers, n) =>
            {
                List<int> result = new();

                foreach (var num in numbers)
                {
                    if (num % n != 0)
                    {
                        result.Add(num);
                    }
                }

                result = reverse(result);

                return result;
            };

            numbers = exclude(numbers, n);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}