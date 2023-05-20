namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main()
        {
            //1 British Pound = 1.31 Dollars
            double pounds = double.Parse(Console.ReadLine());
            double dollars = pounds * 1.31;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}