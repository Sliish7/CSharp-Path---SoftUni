namespace _02.ChangeList
{
    internal class Program
    {
        static void Main()
        { 
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandArgs = input.Split();

                switch (commandArgs[0])
                {
                    case "Insert":
                        int numToInsert = int.Parse(commandArgs[1]);
                        int position = int.Parse(commandArgs[2]);
                        list.Insert(position, numToInsert);
                        break;

                    case "Delete":
                        int numToRemove = int.Parse(commandArgs[1]);
                        list.RemoveAll(x => x == numToRemove);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}