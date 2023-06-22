namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            foreach (var el in numbers)
            {
                int rounded = (int)Math.Round(el, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{el} => {rounded}");
            }
        }
    }
}