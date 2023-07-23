namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main()
        {
            string input;
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split("->");
                string companyName = arguments[0].Trim();
                string employeeID = arguments[1].Trim();

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");
                Console.WriteLine("-- " + string.Join("\n-- ", kvp.Value));
            }
        }
    }
}