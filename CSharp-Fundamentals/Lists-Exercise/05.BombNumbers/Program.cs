namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] args = Console.ReadLine().Split().Select(int.Parse).ToArray();

            numbers = ExplodeFunc(numbers, args);
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine(sum);
        }

        private static List<int> ExplodeFunc(List<int> numbers, int[] args)
        {
            int number = args[0];
            int power = args[1];

            while (numbers.Contains(number))
            {
                int index = numbers.IndexOf(number);

                int leftIndex = Math.Max(0, index - power);
                int rightIndex = Math.Min(numbers.Count - 1, index + power);

                int range = rightIndex - leftIndex + 1;
                numbers.RemoveRange(leftIndex, range);
            }

            return numbers;
        }
    }
}