using System.Text;
using System.Transactions;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main()
        {
            int operations = int.Parse(Console.ReadLine());

            var builder = new StringBuilder();
            Stack<string> updates = new Stack<string>();
            updates.Push(builder.ToString());
            
            while (operations != 0)
            {
                string[] arguments = Console.ReadLine().Split().ToArray();
                int command = int.Parse(arguments[0]);

                switch (command)
                {
                    case 1:
                        builder.Append(arguments[1]);
                        updates.Push(builder.ToString());
                        break;
                    case 2:
                        int num = int.Parse(arguments[1]);
                        builder.Remove(builder.Length - num, num);
                        updates.Push(builder.ToString());
                        break;

                    case 3:
                        int index = int.Parse(arguments[1]);
                        Console.WriteLine(builder[index - 1]);
                        break;

                    case 4: 
                        updates.Pop();
                        builder = new StringBuilder();
                        builder.Append(updates.Peek());
                        break;
                }

                operations--;
            }
        }
    }
}