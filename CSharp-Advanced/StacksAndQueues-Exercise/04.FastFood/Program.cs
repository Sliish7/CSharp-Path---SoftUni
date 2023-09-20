namespace _04.FastFood
{
    internal class Program
    {
        static void Main()
        {
                int quantity = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int biggestOrder = queue.Max();

            while (queue.Count > 0)
            {
                if (quantity >= queue.Peek())
                {
                    quantity -= queue.Peek();
                    queue.Dequeue();
                }
                else
                    break;
            }
            Console.WriteLine(biggestOrder);

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
                Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
        }
    }
}