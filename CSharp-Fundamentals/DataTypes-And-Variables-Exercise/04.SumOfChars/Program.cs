namespace _04.SumOfChars
{
    internal class Program
    {
        static void Main()
        {
            int charCount = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < charCount; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += letter;               
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}