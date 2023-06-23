namespace _02.CommonElements
{
    internal class Program
    {
        static void Main()
        {
            string[] array1 = Console.ReadLine().Split(" ");
            string[] array2 = Console.ReadLine().Split(" ");

            foreach (string str in array2)
            {
                foreach (string str1 in array1)
                {
                    if (str == str1)
                    {
                        Console.Write($"{str1} ");
                    }
                }
            }
        }
    }
}