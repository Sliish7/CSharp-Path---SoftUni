namespace _01.Train
{
    internal class Program
    {
        static void Main()
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            int total = 0;

            for (int i = 0; i < wagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }

            foreach (int p in people)
            {
                Console.Write($"{p} ");
                total += p;
            }

            Console.WriteLine("\n" + total);
        }
    }
}