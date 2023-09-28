namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputRow = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int currSum = 0;

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currElement = matrix[row, col];
                    currSum = currElement + matrix[row + 1, col + 1] +
                        matrix[row + 1, col] + matrix[row, col + 1] +
                        matrix[row + 2, col + 2] + matrix[row + 2, col] +
                        matrix[row, col + 2] + matrix[row + 2, col + 1] + matrix[row + 1, col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = startRow; row <= startRow + 2; row++)
            {
                for (int col = startCol; col <= startCol + 2; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}