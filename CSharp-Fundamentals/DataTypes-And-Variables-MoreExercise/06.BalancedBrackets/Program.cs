namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            bool isOpened = false;

            for (int i = 1; i <= lines; i++)
            {
                string input = Console.ReadLine();

                if (isOpened && input == "(" || !isOpened && input == ")")
                {
                    isBalanced = false;
                    break;
                }
                if (isOpened && input == "(")
                {
                    isBalanced = false;
                    break;
                }

                if (input == "(")
                {
                    isOpened = true;
                    isBalanced = false;
                }
                else if (input == ")")
                {
                    isOpened = false;
                    isBalanced = true;
                }
            }

            if (isBalanced == true)
            {
                Console.WriteLine("BALANCED");
            }
            else
                Console.WriteLine("UNBALANCED");
        }
    }
}