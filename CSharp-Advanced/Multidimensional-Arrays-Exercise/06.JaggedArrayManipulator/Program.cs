using System;

namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            double[][] jaggedMatrix = new double[r][];

            for (int rows = 0; rows < r; rows++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                jaggedMatrix[rows] = new double[numbers.Length]; 

                for (int cols = 0; cols < numbers.Length; cols++)
                {
                    jaggedMatrix[rows][cols] = numbers[cols];
                }
            }
            AnalyzeMatrix(jaggedMatrix);

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] parameters = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = parameters[0];
                int row = int.Parse(parameters[1]);
                int col = int.Parse(parameters[2]);
                double value = double.Parse(parameters[3]);

                if (command == "Add")
                {
                    if ((row >= 0 && row < jaggedMatrix.Length) && (col >= 0 && col < jaggedMatrix[row].Length))
                    {
                       jaggedMatrix[row][col] = AddOperation(jaggedMatrix[row][col], value);
                    }
                }
                else if (command == "Subtract")
                {
                    if ((row >= 0 && row < jaggedMatrix.Length) && (col >= 0 && col < jaggedMatrix[row].Length))
                    {
                        jaggedMatrix[row][col] = SubtractOperation(jaggedMatrix[row][col], value);
                    }
                }
            }

            PrintMatrix(jaggedMatrix);
        }

        private static double SubtractOperation(double num, double value) =>
            num -= value;

        private static double AddOperation(double num, double value) =>
            num += value;

        private static double[][] AnalyzeMatrix(double[][] jaggedMatrix)
        {
            for (int rows = 0; rows < jaggedMatrix.Length - 1; rows++)
            {
                if (jaggedMatrix[rows].Length == jaggedMatrix[rows + 1].Length)
                {
                    jaggedMatrix[rows] = jaggedMatrix[rows].Select(x => x * 2).ToArray();
                    jaggedMatrix[rows + 1] = jaggedMatrix[rows + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[rows] = jaggedMatrix[rows].Select(x => x / 2).ToArray();
                    jaggedMatrix[rows + 1] = jaggedMatrix[rows + 1].Select(x => x /2).ToArray();
                }
            }
            return jaggedMatrix;
        }

        private static void PrintMatrix(double[][] jaggedMatrix)
        {
            for (int rows = 0; rows < jaggedMatrix.Length; rows++)
            {
                for (int cols = 0; cols < jaggedMatrix[rows].Length; cols++)
                {
                    Console.Write($"{jaggedMatrix[rows][cols]} ");
                }
                Console.WriteLine();
            }
        }
    }
}