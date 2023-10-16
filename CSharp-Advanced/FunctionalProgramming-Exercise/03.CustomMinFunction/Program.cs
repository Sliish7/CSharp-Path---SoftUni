namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main()
        {
            Func<int[], int> checkMin = numbers => numbers.Min(x => x);
            
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(checkMin(numbers));
        }
    }
}