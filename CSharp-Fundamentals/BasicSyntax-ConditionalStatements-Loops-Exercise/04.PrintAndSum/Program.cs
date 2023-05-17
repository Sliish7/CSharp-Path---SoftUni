namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main()
        {
            int stN = int.Parse(Console.ReadLine());
            int endN = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = stN; i <= endN; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }

            Console.WriteLine($"\nSum: {sum}");
        }   
    }
}