using System.Runtime.InteropServices;

namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int primaryDiag = 0;
            int secondaryDiag = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (row == col)
                    {
                        primaryDiag += matrix[row, col];
                    }

                    if (col == size - row - 1)
                    {
                        secondaryDiag += matrix[row, col];
                    }
                }
            }

            int result = Math.Abs(primaryDiag - secondaryDiag);
            Console.WriteLine(result);
        }
    }
}