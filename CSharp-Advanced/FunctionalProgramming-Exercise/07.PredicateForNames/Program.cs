namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<int, List<string>, List<string>> sort = (n, names) =>
            {
                List<string> result = new();

                foreach (string name in names)
                {
                    if (name.Length <= n)
                    {
                        result.Add(name);
                    }
                }

                return result;
            };

            Action<List<string>> print = names => Console.WriteLine(string.Join("\n", names));

            names = sort(n, names);
            print(names);
        }
    }
}