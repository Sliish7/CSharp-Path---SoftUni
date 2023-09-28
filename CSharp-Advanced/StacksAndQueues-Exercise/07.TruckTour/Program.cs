namespace _07.TruckTour
{
    internal class Program
    {
        static void Main()
        {
            int pumpCount = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < pumpCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(input);
            }

            int bestRoute = 0;

            while (true)
            {
                int totalLitres = 0;

                foreach (int[] p in pumps)
                {
                    totalLitres += p[0];
                    int currDistance = p[1];
                    
                    if (totalLitres - currDistance < 0)
                    {
                        totalLitres = 0;
                        break;
                    }
                    else
                        totalLitres -= currDistance;
                }

                if (totalLitres > 0)
                {
                    break;
                }

                bestRoute++;
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(bestRoute);
        }
    }
}