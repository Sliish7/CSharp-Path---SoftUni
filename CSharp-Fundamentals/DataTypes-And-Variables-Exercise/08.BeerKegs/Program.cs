namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main()
        {
            int kegs = int.Parse(Console.ReadLine());
            double v = double.MinValue;
            string biggestKeg = "";

            while (kegs != 0)
            {
                string currKeg = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double currV = Math.PI * Math.Pow(r, 2) * h;

                if (currV > v)
                {
                    v = currV;
                    biggestKeg = currKeg;
                }
                kegs--;
            }

            Console.WriteLine(biggestKeg);
        }
    }
}