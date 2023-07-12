namespace _04.ListOperations
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input.Split();

                switch (commandArgs[0])
                {
                    case "Add":
                        int numToAdd = int.Parse(commandArgs[1]);
                        list.Add(numToAdd);
                        break;

                    case "Insert":
                        int numToInsert = int.Parse(commandArgs[1]);
                        int index = int.Parse(commandArgs[2]);

                        if (index >= 0 && index <= list.Count)
                        {
                            list.Insert(index, numToInsert);
                        }
                        else
                            Console.WriteLine("Invalid index");
                        break;

                    case "Remove":
                        index = int.Parse(commandArgs[1]);
                        if (index >= 0 && index <= list.Count)
                        {
                            list.RemoveAt(index);
                        }
                        else
                            Console.WriteLine("Invalid index");
                        break;

                    case "Shift":
                        int count = int.Parse(commandArgs[2]);
                        if (commandArgs[1] == "left")
                        {
                            list = ShiftLeft(list, count);
                        }
                        else if (commandArgs[1] == "right")
                        {
                            list = ShiftRight(list, count);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static List<int> ShiftLeft(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int currNum = list.First();
                list.RemoveAt(0);
                list.Add(currNum);
            }
            return list;
        }

        private static List<int> ShiftRight(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int currNum = list.Last();
                list.RemoveAt(list.Count - 1);
                list.Insert(0, currNum);
            }
            return list;
        }
    }
}