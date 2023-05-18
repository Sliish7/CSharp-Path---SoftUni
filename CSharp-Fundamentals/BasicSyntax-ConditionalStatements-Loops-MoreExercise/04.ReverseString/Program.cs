namespace _04.ReverseString
{
    internal class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write(charArray[i]);
            }
        }
    }
}