namespace _03.HouseParty
{
    internal class Program
    {
        static void Main()
        {
            int commandCount = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 1; i <= commandCount; i++)
            {
                string command = Console.ReadLine();
                string[] args = command.Split();
                string name = args[0];
                if (command.Contains("not") && !names.Contains(name))
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
                else if (command.Contains("not"))
                {
                    names.Remove(name);
                }
                else if (names.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                    names.Add(name);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}