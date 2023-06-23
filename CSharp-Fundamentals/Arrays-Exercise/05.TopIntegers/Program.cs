namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();            
            int len = array.Length;
            int[] numbers = new int[len];
            int indexCounter = 0;

            for (int i = 0; i < len; i++)
            {
                bool isBiggest = true;

                for (int j = i + 1; j < len; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isBiggest = false;
                        break;
                    }
                }

                if (isBiggest)
                {
                    numbers[indexCounter++] = array[i];
                }
            }

            Array.Resize(ref numbers, indexCounter);
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}