using System.Xml;

namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main()
        {
            int[] count = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            for (int i = 0; i < count[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < count[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(" ", set1.Intersect(set2)));
        }
    }
}