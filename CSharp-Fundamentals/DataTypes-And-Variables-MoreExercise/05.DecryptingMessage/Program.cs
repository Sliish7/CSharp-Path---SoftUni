namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main()
        {
            int steps = int.Parse(Console.ReadLine());
            int letters = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 1; i <= letters; i++)
            {
                char lett = (char)(char.Parse(Console.ReadLine()) + steps);
                word += lett.ToString();
            }
            Console.WriteLine(word);
        }
    }
}