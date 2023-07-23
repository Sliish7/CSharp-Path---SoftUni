namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main()
        {
            string[] path = Console.ReadLine().Split('\\');
            string[] tokens = path[path.Length - 1].Split(".");
            Console.WriteLine($"File name: {tokens[0]}");
            Console.WriteLine($"File extension: {tokens[1]}");
        }
    }
}