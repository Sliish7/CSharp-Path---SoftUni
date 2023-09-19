namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main()
        {
            // 1 x - push x | 2 delete | 3 print max | 4 print min

            int queries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < queries; i++)
            {
                List<int> arguments = Console.ReadLine().Split().Select(int.Parse).ToList();

                switch (arguments[0])
                {
                    case 1: stack.Push(arguments[1]); break;
                    case 2: stack.Pop(); break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4 :
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(',', stack));
        }
    }
}