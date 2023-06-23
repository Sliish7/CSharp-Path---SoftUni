using System.Security.Cryptography.X509Certificates;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var numbersList = input.ToList();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                numbersList.Add(numbersList[0]);
                numbersList.RemoveAt(0);
            }

            Console.WriteLine(string.Join(" ", numbersList));
        }
    }
}