namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main()
        {
            int capacity = 255;
            int lInTank = 0;
            int interval = int.Parse(Console.ReadLine());

            for (int i = 0; i < interval; i++)
            {
                int lToPour = int.Parse(Console.ReadLine());

                if (capacity - lInTank < lToPour)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                lInTank += lToPour;
            }

            Console.WriteLine(lInTank);
        }
    }
}