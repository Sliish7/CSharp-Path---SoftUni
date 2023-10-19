namespace _05.GenericCountMethodString
{
    internal class StartUp
    {
        static void Main()
        {
            Box<string> box = new();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();
                box.Add(item);
            }

            string comparableItem = Console.ReadLine();
            Console.WriteLine(box.Count(comparableItem));
        }
    }
}