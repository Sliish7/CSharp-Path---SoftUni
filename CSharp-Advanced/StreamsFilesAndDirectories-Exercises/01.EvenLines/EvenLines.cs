namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new();
            using StreamReader sr = new(inputFilePath);

            string line = string.Empty;
            int count = 0;

            while (line != null)
            {
                line = sr.ReadLine();

                if (count % 2 == 0)
                {
                    string replaced = ReplaceSymbols(line);
                    string reversed = ReverseWords(replaced);
                    sb.AppendLine(reversed);
                }

                count++;
            }


            return sb.ToString().TrimEnd();
        }

        private static string ReplaceSymbols(string line)
        {
            char[] symbols = { '-', ',', '.', '!', '?' };

            foreach (char symbol in symbols)
            {
                line = line.Replace(symbol, '@');
            }

            return line.TrimEnd();
        }

        private static string ReverseWords(string line)
        {
            string[] words = line
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            string reversed = string.Join(" ", words);
            return reversed;
        }
    }
}
