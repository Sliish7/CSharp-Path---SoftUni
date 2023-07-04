using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Transactions;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string input =string.Empty;
            int[] bestDNA = null;

            int counterDNA = 1;
            int bestSequenceIndex = 1;
            int bestSequenceSum = 0;
            int bestCount = 0;
            int bestLeftmost = length;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] currentDNA = input.Split("!").Select(int.Parse).ToArray();
                int currentCount = 0;
                int biggestCurrCount = 0;
                int currentLeftmostIndex = 0;
                int currSequenceSum = 0;

                for (int i = 1; i <= currentDNA.Length; i++)
                {
                    if (currentDNA[i - 1] == 1)
                    {
                        currentCount++;
                        currSequenceSum ++;

                        if (currentCount > biggestCurrCount)
                        {
                            currentLeftmostIndex = i - currentCount;
                            biggestCurrCount = currentCount;
                        }

                    }
                    else
                        currentCount = 0;

                    
                }


                if (bestCount == biggestCurrCount)
                {
                    if (bestLeftmost > currentLeftmostIndex)
                    {
                        bestDNA = currentDNA;
                        bestCount = biggestCurrCount;
                        bestLeftmost = currentLeftmostIndex;
                        bestSequenceIndex = counterDNA;
                        bestSequenceSum = currSequenceSum;

                    }
                    else if (bestLeftmost == currentLeftmostIndex)
                    {
                        if (CompareSum(bestDNA,currentDNA) == true)
                        {
                            bestDNA = currentDNA;
                            bestCount = biggestCurrCount;
                            bestLeftmost = currentLeftmostIndex;
                            bestSequenceIndex = counterDNA;
                            bestSequenceSum = currSequenceSum;
                        }
                    }
                }
                else if (bestCount < biggestCurrCount)
                {
                    bestDNA = currentDNA;
                    bestCount = biggestCurrCount;
                    bestLeftmost = currentLeftmostIndex;
                    bestSequenceIndex = counterDNA;
                    bestSequenceSum = currSequenceSum;
                }

                counterDNA++;
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }

        private static bool CompareSum(int[] bestDNA, int[] currentDNA)
        {
            int bestDNAsum = 0;
            int currDNAsum = 0;
            bool isBetter = false;

            for (int i = 0; i < bestDNA.Length; i++)
            {

                if (bestDNA[i] == 1)
                {
                    bestDNAsum++;
                }
                if (currentDNA[i] == 1)
                {
                    currDNAsum++;
                }
            }

            if (currDNAsum > bestDNAsum)
            {
                isBetter = true;
            }

            return isBetter;
        }
    }
}