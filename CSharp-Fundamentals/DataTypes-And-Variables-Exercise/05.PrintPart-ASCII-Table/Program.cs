namespace _05.PrintPart_ASCII_Table
{
    internal class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                char currASCII = (char)i;
                if (i != end)
                {
                    Console.Write(currASCII + " ");
                }
                else
                    Console.Write(currASCII);
            }
        }
    }
}