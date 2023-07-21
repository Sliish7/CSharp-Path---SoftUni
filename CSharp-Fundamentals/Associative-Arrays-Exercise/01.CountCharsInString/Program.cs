using System.Security.Cryptography.X509Certificates;

namespace _01.CountCharsInString
{
    internal class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().Replace(" ","").ToCharArray();

            var symbols = new Dictionary<char, double>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!symbols.ContainsKey(input[i]))
                {
                    symbols[input[i]] = 0;
                }
                symbols[input[i]]++;
            }

            foreach (var s in symbols)
            {
                Console.WriteLine($"{s.Key} -> {s.Value}");
            }
        }
    }
}