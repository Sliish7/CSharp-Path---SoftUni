namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<int,int> numbers = new Dictionary<int,int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else
                    numbers[number]++;
            }

            foreach (var kvp in numbers)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                }
            }
        }
    }
}