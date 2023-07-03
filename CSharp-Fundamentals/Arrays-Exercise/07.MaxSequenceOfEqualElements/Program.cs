using System.Diagnostics.Metrics;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Counter(arr));
        }

        private static int Counter(int[] arr)
        {
            int counter = 0;
            int previousNum;
            foreach (int num in arr)
            {
                if (num == previousNum)
                {

                }

                previousNum = num;

            }

            return 0;
        }
    }
}