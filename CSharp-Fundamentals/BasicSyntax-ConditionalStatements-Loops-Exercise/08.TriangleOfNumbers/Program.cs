namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int currNum = i;
                for (int j = 1; j <= currNum; j++)
                {
                    if (currNum > j)
                    {
                        Console.Write($"{currNum} ");
                    }
                    else
                        Console.Write($"{currNum}\n");
                }
            }
        }
    }
}