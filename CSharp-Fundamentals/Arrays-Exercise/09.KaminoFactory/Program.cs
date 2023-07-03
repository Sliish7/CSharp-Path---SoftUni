using System.Transactions;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string input =string.Empty;
            int[] bestDNA = {0, 0, 0, 0, 0};
            int biggestCount = 1;
            int leftmostIndex = length;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] dna = input.Split(" ").Select(int.Parse).ToArray();
                int startIndex = length;
                int count = 0;

                for (int i = 0; i < length; i++)
                {
                    if (dna[i] == 1)
                    {
                        if (count < biggestCount && startIndex > leftmostIndex)
                        {
                            startIndex = i;
                        }
                        count++;

                    }
                    else
                        count = 0;

                }

                if (count >= biggestCount && startIndex <= leftmostIndex)
                {
                    leftmostIndex = startIndex;
                    biggestCount = count;
                    bestDNA = dna;
                }
            }

            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}