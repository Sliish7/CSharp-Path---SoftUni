namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main()
        {
            int[] arrNum = {0, 0, 0};

            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arrNum[i] = num;
            }

            for (int i = 0; i < arrNum.Length; i++)
            {
                Array.Sort(arrNum);
                Array.Reverse(arrNum);
                Console.WriteLine(arrNum[i]);
            }

        }
    }
}