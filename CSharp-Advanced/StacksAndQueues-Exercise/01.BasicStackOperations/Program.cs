namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main()
        {
            List<int> arguments = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int numbers = arguments[0];
            int pops = arguments[1];
            int target = arguments[2];

            //if found output - print true  | if !found - print smallest | if <stack_count - print 0

            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            if (pops < stack.Count)
            {
                for (int i = 0; i < pops; i++)
                {
                    stack.Pop();
                }

                if (stack.Contains(target))
                {
                    Console.WriteLine(true);
                }
                else
                    Console.WriteLine(stack.Min());
            }
            else
                Console.WriteLine(0);

        }
    }
}