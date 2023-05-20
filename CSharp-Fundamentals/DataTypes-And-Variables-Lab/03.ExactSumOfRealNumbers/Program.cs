namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main()
        {
            int numCount = int.Parse(Console.ReadLine());
            decimal result = 0;

            for (int i = 0; i < numCount; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                result += num;
            }
            Console.WriteLine($"{result}");
        }
    }
}