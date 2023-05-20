namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= range; i++)
            {
                int num = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                bool isSpecial = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", num, isSpecial);
                total = 0;
                i = num;
            }
        }
    }
}