namespace LeastSignificantBit
{
    internal class Program
    {
        static void Main()
        {
            int mask = 1;
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number & mask);
        }
    }
}