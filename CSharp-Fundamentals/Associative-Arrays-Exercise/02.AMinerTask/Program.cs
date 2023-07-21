namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main()
        {
            string input;
            var resources = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                    resources[resource] = quantity;
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}