namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string filtered = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    filtered += input[0];
                }
                else if (input[i] != input[i - 1])
                {
                    filtered += input[i];
                }
            }
            Console.WriteLine(filtered);
        }
    }
}