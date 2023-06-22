namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(" ");
            Array.Reverse(strings);

            foreach (string str in strings)
            {
                Console.Write($"{str} ");
            }
        }
    }
}