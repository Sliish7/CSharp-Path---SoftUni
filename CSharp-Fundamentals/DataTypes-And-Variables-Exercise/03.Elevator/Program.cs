namespace _03.Elevator
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int cources = (int)Math.Ceiling((double)people / capacity);

            Console.WriteLine(cources);
        }
    }
}