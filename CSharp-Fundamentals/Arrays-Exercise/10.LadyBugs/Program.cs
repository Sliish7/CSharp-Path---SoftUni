using System;
using System.Reflection.Metadata.Ecma335;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main()
        {
            string input = string.Empty;
            int fieldSize = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];

            BugsPlacing(field, indexes);

            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                Flying(command, field);
            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static int[] Flying(string[] command, int[] field)
        {
            int bugIndex = int.Parse(command[0]);
            string position = command[1];
            int flyLength = int.Parse(command[2]);

            if (bugIndex > field.Length - 1|| bugIndex < 0)
            {
                return field;
            }
            else if (flyLength == 0)
            {
                return field;
            }
            else if ((bugIndex + flyLength > field.Length && position == "right") || (bugIndex - flyLength < 0 && position == "left"))
            {
                field[bugIndex] = 0;
                return field;
            }
           
            if (field[bugIndex] != 0)
            {
                if (position == "left")
                {
                    for (int i = bugIndex - flyLength; i >= 0; i--)
                    {
                        if (field[i] != 1)
                        {
                            field[i] = 1;
                            break;
                        }

                        i -= flyLength - 1;
                    }
                    field[bugIndex] = 0;
                }
                else if (position == "right")
                {
                    for (int i = bugIndex + flyLength; i < field.Length; i++)
                    {
                        if (field[i] != 1)
                        {
                            field[i] = 1;
                            break;
                        }

                        i += flyLength - 1;
                    }
                    field[bugIndex] = 0;
                }
            }
            return field;
        }

        private static int[] BugsPlacing(int[] field, int[] indexes)
        {
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < indexes.Length; j++)
                {
                    if (i == indexes[j])
                    {
                        field[i] = 1;
                    }
                }
            }
            return field;

        }
    }
}