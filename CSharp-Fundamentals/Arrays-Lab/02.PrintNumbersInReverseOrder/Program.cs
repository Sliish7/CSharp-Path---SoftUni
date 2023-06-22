namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}