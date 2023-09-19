namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main()
        {
            List<int> arguments = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int numbers = arguments[0];
            int dequeues = arguments[1];
            int target = arguments[2];

            //if found output - print true  | if !found - print smallest | if <queue_count - print 0

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            if (dequeues < queue.Count)
            {
                for (int i = 0; i < dequeues; i++)
                {
                    queue.Dequeue();
                }

                if (queue.Contains(target))
                {
                    Console.WriteLine("True");
                }
                else
                    Console.WriteLine(queue.Min());
            }
            else
                Console.WriteLine(0);
        }
    }
}