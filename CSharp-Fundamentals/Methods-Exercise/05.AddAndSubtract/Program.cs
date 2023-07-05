using System.Diagnostics.CodeAnalysis;

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Sum() - Substract();
            Console.WriteLine(result);
        }

        private static int Substract()
        {
            int c = int.Parse(Console.ReadLine());
            return c;
        }

        private static int Sum()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            return result;
        }
    }
}