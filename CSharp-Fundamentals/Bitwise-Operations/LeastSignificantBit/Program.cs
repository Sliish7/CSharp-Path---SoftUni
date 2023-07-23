using System.Text;

namespace LeastSignificantBit
{
    internal class Program
    {
        static void Main()
        {
            int mask = 1;
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number & mask);
            int count = 0;

            int a = 2100354420;
            int b = 2135231231;

            StringBuilder sb = new StringBuilder();
            sb.Append((a * b).ToString());
            Console.WriteLine(sb);
            Console.WriteLine(a*b);
        }
    }
}