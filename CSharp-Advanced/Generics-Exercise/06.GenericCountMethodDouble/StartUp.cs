namespace _06.GenericCountMethodDouble
{
    internal class StartUp
    {
        static void Main()
        {
            Box<double> box = new();
            double count = double.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double item = double.Parse(Console.ReadLine());
                box.Add(item);
            }

            double comparableItem = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(comparableItem));
        }
    }
}