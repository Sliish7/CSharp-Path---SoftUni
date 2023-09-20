namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;
            while (stack.Count > 0)
            {
                if (sum + stack.Peek() > capacity)
                {
                    sum = 0;
                    racks++;
                }
                else
                    sum += stack.Pop();
            }

            Console.WriteLine(racks);
        }
    }
}