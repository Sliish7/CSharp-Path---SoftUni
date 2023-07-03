using System.Runtime.CompilerServices;

namespace _08.MagicSum
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            UniquePairs(numbers, magicNumber);
        }

        private static void UniquePairs(int[] numbers, int magicNumber)
        {
            List<int> pairs = new List<int>();
            int firstN = 0;
            int secondN = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                firstN = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    secondN = numbers[j];
                    int result = firstN + secondN;

                    if (result == magicNumber)
                    {
                        Console.WriteLine($"{firstN} {secondN}");
                    }
                }
            }
        }
    }
}