namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            foreach (int number in numbers)
            {
                int currNum = number;

                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}