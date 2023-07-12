namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main()
        {
            string[] stringsArrays = Console.ReadLine().Split('|');
            List<int> numList = new List<int>();
            ExtractNums(stringsArrays, numList);
        }

        private static void ExtractNums(string[] stringsArrays, List <int> numList)
        {
            for (int i = stringsArrays.Length - 1; i >= 0; i--)
            {
                int[] array = stringsArrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                numList.AddRange(array);
            }
            Console.WriteLine(string.Join(" ", numList));
        }
    }
}   