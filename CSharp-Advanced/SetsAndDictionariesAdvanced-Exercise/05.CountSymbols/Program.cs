namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            SortedDictionary<char, int> chars = new SortedDictionary<char, int>();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (!chars.ContainsKey(charArray[i]))
                {
                    chars[charArray[i]] = 0;
                }

                chars[charArray[i]]++;
            }

            foreach (var kvp in chars)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}