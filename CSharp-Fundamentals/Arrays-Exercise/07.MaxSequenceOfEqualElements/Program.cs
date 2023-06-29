using System.Diagnostics.Metrics;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToList());
            int topNum = 0;
            int counter = 0;

            foreach (int num in numbers)
            {
                int index = numbers.IndexOf(num);
                int prevNum = index;
                counter++;

                if (index == 0)
                {

                }
                else
                    prevNum = num;

                int biggestCounter = 0;

                if (num != prevNum && index != 0)
                {
                    counter = 0;
                }


                if (counter > biggestCounter)
                {
                    biggestCounter = counter;
                    topNum = num;
                }

                Console.WriteLine($"Num {num} prevNum {prevNum} counter {counter} biggestConter{biggestCounter} Top Number for now: {topNum}");

            }

            Console.WriteLine(topNum);
        }
    }
}