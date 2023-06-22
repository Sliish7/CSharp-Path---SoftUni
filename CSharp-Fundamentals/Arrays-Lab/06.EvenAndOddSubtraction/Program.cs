namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumOdd = 0;
            int sumEven = 0;

            foreach (var number in numbers)
            {
                int currNum = number;

                if (currNum % 2 == 0)
                {
                    sumEven += currNum;
                }
                else
                    sumOdd += currNum;
            }
            Console.WriteLine(sumEven - sumOdd);
        }
    }
}