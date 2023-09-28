namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] inputRow = Console.ReadLine().Replace(" ", "").ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++) //Prevent getting out of the array.
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currElement = matrix[row, col];

                    if (currElement == matrix[row + 1, col] && currElement == matrix[row, col +1] && currElement == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}