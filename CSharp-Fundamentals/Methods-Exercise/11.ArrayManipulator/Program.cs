using System;
using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Xml;
using System.Xml.Linq;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commandArgs = input.Split();
                switch (commandArgs[0])
                {
                    case "exchange":
                        int index = int.Parse(commandArgs[1]);
                        numbers = ExchangeNumbers(numbers, index);

                        break;
                    case "max":
                        string oddOrEven = commandArgs[1];
                        PrintMax(numbers, oddOrEven);

                        break;
                    case "min":
                        oddOrEven= commandArgs[1];
                        PrintMin(numbers, oddOrEven);

                        break;
                    case "first":
                        int count = int.Parse(commandArgs[1]);
                        oddOrEven = commandArgs[2];
                        PrintFirstXNumbers(numbers, count, oddOrEven);

                        break;
                    case "last":
                        count = int.Parse(commandArgs[1]);
                        oddOrEven = commandArgs[2];
                        PrintLastXNumbers(numbers, count, oddOrEven);

                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        private static void PrintFirstXNumbers(int[] numbers, int count, string oddOrEven)
        {
            if (count <= 0 || count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int arrCount = 0;
            int elementCount = 0;
            bool atleastOneNum = false;
            string firstElements = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (arrCount == count)
                {
                    break;
                }

                if (IsOdd(currNum, oddOrEven))
                {
                    firstElements += $"{currNum}, ";
                    arrCount++;
                    atleastOneNum = true;
                }
                else if (IsEven(currNum, oddOrEven))
                {
                    firstElements += $"{currNum}, ";
                    arrCount++;
                    atleastOneNum = true;
                }
            }

            if (atleastOneNum)
            {
                Console.WriteLine($"[{firstElements.Trim(' ',',')}]");
            }
            else
                Console.WriteLine("[]");
        }

        private static void PrintLastXNumbers(int[] numbers, int count, string oddOrEven)
        {
            if (count <= 0 || count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int arrCount = 0;
            int elementCount = 0;
            bool atleastOneNum = false;
            string lastElements = "";

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currNum = numbers[i];
                if (arrCount == count)
                {
                    break;
                }

                if (IsOdd(currNum, oddOrEven))
                {
                    lastElements = $"{currNum}, " + lastElements;
                    arrCount++;
                    atleastOneNum = true;
                }
                else if (IsEven(currNum, oddOrEven))
                {
                    lastElements = $"{currNum}, " + lastElements;
                    arrCount++;
                    atleastOneNum = true;
                }
            }

            if (atleastOneNum)
            {
                Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
            }
            else
                Console.WriteLine("[]");
        }

        private static void PrintMin(int[] numbers, string oddOrEven)
        {
            {
                int minNum = int.MaxValue;
                int minIndex = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int currNum = numbers[i];
                    if (IsOdd(currNum, oddOrEven) || IsEven(currNum, oddOrEven))
                    {
                        if (currNum <= minNum)
                        {
                            minNum = currNum;
                            minIndex = i;
                        }
                    }
                }

                if (minIndex != -1)
                {
                    Console.WriteLine(minIndex);
                }
                else
                    Console.WriteLine("No matches");
            }
        }

        private static void PrintMax(int[] numbers, string oddOrEven)
        {
            int maxNum = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (IsOdd(currNum, oddOrEven) || IsEven(currNum, oddOrEven))
                {
                    if (currNum >= maxNum)
                    {
                        maxNum = currNum;
                        maxIndex = i;
                    }
                }                
            }

            if (maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
                Console.WriteLine("No matches");
        }

        private static bool IsEven(int currNum, string oddOrEven)
        {
            return oddOrEven == "even" && currNum % 2 == 0;
        }

        private static bool IsOdd(int currNum, string oddOrEven)
        {
            return oddOrEven == "odd" && currNum % 2 != 0;
        }

        private static int[] ExchangeNumbers(int[] numbers, int index)
        {

            if (index >= 0 && index < numbers.Length)
            {
                int[] numsBefore = new int[index + 1];
                int[] numsAfter = new int[numbers.Length - numsBefore.Length];

                numsBefore = numbers.Take(index + 1).ToArray();
                numsAfter = numbers.Skip(index + 1).ToArray();

                numbers = numsAfter.Concat(numsBefore).ToArray();
            }
            else
                Console.WriteLine("Invalid index");

            return numbers;
        }
    }
}