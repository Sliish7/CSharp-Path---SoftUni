namespace _08.BalancedParenthesis
{
    internal class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            char[] openingBrackets = { '[', '{', '(' };
            char[] closingBrackets = { ']', '}', ')' };

            foreach (char currChar in input)
            {
                if (openingBrackets.Contains(currChar))
                {
                    stack.Push(currChar);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }

                    int index = 0;

                    for (int i = 0; i < closingBrackets.Length; i++)
                    {
                        if (currChar == closingBrackets[i])
                        {
                            index = i;
                        }
                    }

                    if (stack.Peek() == openingBrackets[index])
                    {
                        stack.Pop();
                    }
                    else
                        isValid= false;
                }
            }

            Console.Write(isValid ? "YES" : "NO");
        }
    }
}