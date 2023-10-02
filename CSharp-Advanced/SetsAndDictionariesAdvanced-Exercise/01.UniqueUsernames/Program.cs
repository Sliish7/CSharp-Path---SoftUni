namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                names.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}