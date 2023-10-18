namespace _09.PredicateParty
{
    internal class Program
    {
        static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                switch (action)
                {
                    case "Remove":
                        people.RemoveAll(GetPredicate(filter, value));
                        break;
                    case "Double":
                        List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));

                        foreach (var p in peopleToDouble)
                        {
                            int index = people.FindIndex(x => x == p);
                            people.Insert(index, p);
                        }
                        break;
                }
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
                Console.WriteLine("Nobody is going to the party!");
        }

        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith": return p => p.StartsWith(value);
                case "EndsWith": return p => p.EndsWith(value);
                case "Length": return p => p.Length == int.Parse(value);
                default: return default;
            }
        }
    }
}