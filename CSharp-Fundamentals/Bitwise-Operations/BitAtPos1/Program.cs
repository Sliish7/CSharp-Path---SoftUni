namespace BitAtPos1
{
    internal class Program
    {
        static void Main()
        {
            int num = 2145; int pos = 5;
            int mask = 1 << pos;
            int result = num & mask;
            int lsb = result >> pos;

            Console.WriteLine(lsb);
        }
    }
}