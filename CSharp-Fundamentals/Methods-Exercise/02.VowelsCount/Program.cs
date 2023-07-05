namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Console.WriteLine(VowelsCount(input));
        }

        private static int VowelsCount(char[] input)
        {
            List<char> vowels = new List<char> { 'a', 'A', 'e', 'E', 'i', 'I', 'u', 'U', 'o', 'O' };
            int count = 0;

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }              
            }

            return count;
        }
    }
}