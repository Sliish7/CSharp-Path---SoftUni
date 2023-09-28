namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowInput = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                Queue<string> queue = new Queue<string>(command.Split(' '));
                if (queue.Peek() != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                queue.Dequeue();

                if (queue.Count < 4 || queue.Count > 4)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(queue.Dequeue());
                int col1 = int.Parse(queue.Dequeue());
                int row2 = int.Parse(queue.Dequeue());
                int col2 = int.Parse(queue.Dequeue());

                if (row1 >= size[0] || row2 >= size[0] || col1 >= size[1] || col2 >= size[1])
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int num1 = matrix[row1, col1];
                int num2 = matrix[row2, col2];

                matrix[row1, col1] = num2;
                matrix[row2, col2] = num1;
                
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write($"{matrix[row, col]} ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}