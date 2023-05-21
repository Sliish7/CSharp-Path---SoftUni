namespace _09.CharsToString
{
    internal class Program
    {
        static void Main()
        {
            char[] chars = new char[3];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }
            foreach (char c in chars)
            {
                Console.Write(c);
            }
        }
    }
}