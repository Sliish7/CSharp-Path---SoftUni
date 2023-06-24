namespace _06.EqualSum
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToList());
            bool isFound = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = i;
                int leftSum = 0;
                int rightSum = 0;

                for (int k = 0; k < index; k++)
                {
                    leftSum += numbers[k];
                }
                for (int j = index + 1; j < numbers.Count; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(index);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}