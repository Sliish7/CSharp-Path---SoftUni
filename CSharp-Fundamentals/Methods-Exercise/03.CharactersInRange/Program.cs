using System.Text;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(" ", CharactersInRange()));
        }

        private static List<char> CharactersInRange()
        {
            List<char> charList = new List<char>();

            int startChar = (int)(char.Parse(Console.ReadLine()));
            int endChar = (int)(char.Parse(Console.ReadLine()));

            if (startChar < endChar)
            {
                for (int i = startChar + 1; i < endChar; i++)
                {
                    char currChar = (char)i;
                    charList.Add(currChar);
                }
            }
            else
            {
                int tempVariable = endChar;
                endChar = startChar;
                startChar = tempVariable;

                for (int i = startChar + 1; i < endChar; i++)
                {
                    char currChar = (char)i;
                    charList.Add(currChar);
                }
            }

            return charList;
        }
    }
}