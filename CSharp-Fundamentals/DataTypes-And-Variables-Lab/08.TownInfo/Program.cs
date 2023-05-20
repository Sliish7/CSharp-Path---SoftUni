namespace _08.TownInfo
{
    internal class Program
    {
        static void Main()
        {
            string town = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            string output = $"Town {town} has population of" +
                        $" {population} and area {area} square km.";
            Console.WriteLine(output);
        }
    }
}