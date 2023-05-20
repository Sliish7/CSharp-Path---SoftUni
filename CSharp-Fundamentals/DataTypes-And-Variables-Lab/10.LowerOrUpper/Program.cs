namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main()
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter != letter.ToString().ToLower()[0])
            {
                Console.WriteLine("upper-case");
            }
            else
                Console.WriteLine("lower-case");
        }
    }
}