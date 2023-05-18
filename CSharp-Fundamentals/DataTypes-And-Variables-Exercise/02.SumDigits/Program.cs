namespace _02.SumDigits
{
    internal class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int result = 0;

            char[] charArray = number.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                int num = charArray[i] - '0';
                result += num;
            }
            Console.WriteLine(result);
        }
    }
}