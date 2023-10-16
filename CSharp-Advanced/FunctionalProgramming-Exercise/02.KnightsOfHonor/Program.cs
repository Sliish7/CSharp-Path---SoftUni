namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main()
        {
            Action<string[]> print = names =>
            {
                foreach (string name in names)
                {
                    Console.WriteLine($"Sir {name}");
                }
            };

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(names);
        }
    }
}