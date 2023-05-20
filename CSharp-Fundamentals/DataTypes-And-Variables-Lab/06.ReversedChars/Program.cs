namespace _06.ReversedChars
{
    internal class Program
    {
        static void Main()
        {
            string charStr = "";

            for (int i = 1; i <= 3; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                if (i != 3)
                {
                    charStr += currChar + " ";
                }
                else
                    charStr += currChar;
            }
            char[] charArray = charStr.ToCharArray();
            Array.Reverse(charArray);

            foreach (char c in charArray)
            {
                Console.Write(c);
            }
        }
    }
}