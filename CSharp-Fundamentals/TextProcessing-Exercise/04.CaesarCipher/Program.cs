using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);

            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(sb[i] + 3));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}