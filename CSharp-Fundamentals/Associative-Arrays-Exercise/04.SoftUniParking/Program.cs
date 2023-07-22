namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> licensePlates = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];
                string name = commandArgs[1];

                switch (command)
                {
                    case "register":
                        string plateNum = commandArgs[2];
                        if (!licensePlates.ContainsKey(name))
                        {
                           licensePlates[name] = plateNum;
                            Console.WriteLine($"{name} registered {licensePlates[name]} successfully");
                        }
                        else
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlates[name]}");
                        break;
                    case "unregister":
                        if (licensePlates.ContainsKey(name))
                        {
                            licensePlates.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else
                            Console.WriteLine($"ERROR: user {name} not found");
                        break;
                }
            }

            foreach (KeyValuePair<string,string> kvp in licensePlates)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}