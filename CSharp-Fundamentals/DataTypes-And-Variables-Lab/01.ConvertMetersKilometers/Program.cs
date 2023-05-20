namespace _01.ConvertMetersKilometers
{
    internal class Program
    {
        static void Main()
        {
            int m = int.Parse(Console.ReadLine());
            double km = (double)m/1000;
            Console.WriteLine($"{km:f2}");
        }
    }
}