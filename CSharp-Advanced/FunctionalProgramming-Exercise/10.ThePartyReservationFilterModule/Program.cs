﻿namespace _10.ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main()
        {

            List<string> people = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            Dictionary<string, Predicate<string>> filters = new();

            string command;

            while ((command = Console.ReadLine()) != "Print")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                switch (action)
                {
                    case "Add filter":
                        if (!filters.ContainsKey(filter + value))
                        {
                            filters.Add(filter + value, GetPredicate(filter, value));
                        }
                        break;
                    case "Remove filter":
                        filters.Remove(filter + value);
                        break;
                }
            }

            foreach (var f in filters)
            {
                people.RemoveAll(f.Value);
            }

            Console.WriteLine(string.Join(" ", people));
        }

        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "Starts with": return p => p.StartsWith(value);
                case "Ends with": return p => p.EndsWith(value);
                case "Length": return p => p.Length == int.Parse(value);
                case "Contains": return p => p.Contains(value);
                default: return default;
            }
        }
    }
}