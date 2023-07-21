namespace BitDestroyer
{
    internal class Program
    {
        static void Main()
        {
            int num = 1313; int pos = 5;
            int mask = ~(1 << pos);
            int result = num & mask;
            Console.WriteLine(result);
        }
    }
}