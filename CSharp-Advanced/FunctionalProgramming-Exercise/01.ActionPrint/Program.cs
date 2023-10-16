namespace _01.ActionPrint
{
    internal class Program
    {
        static void Main()
        {
            Action<string[]> print = names =>
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            };

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(names);
        }
    }
}