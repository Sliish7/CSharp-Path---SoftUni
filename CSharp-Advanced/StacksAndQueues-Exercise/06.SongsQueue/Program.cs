namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "Play": queue.Dequeue(); break;

                    case "Show": Console.WriteLine(string.Join(", ", queue)); break;

                    default:
                        if (command.StartsWith("Add "))
                        {
                            string song = command.Substring(4);
                            if (!queue.Contains(song))
                            {
                                queue.Enqueue(song);
                            }
                            else
                                Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}