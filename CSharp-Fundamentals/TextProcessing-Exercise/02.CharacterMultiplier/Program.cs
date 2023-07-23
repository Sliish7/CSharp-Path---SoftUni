namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");
            int result = StringSum(input[0], input[1]);

            Console.WriteLine(result);
        }

        private static int StringSum(string fn, string sn)
        {
            int sum = 0;
            int len = Math.Max(fn.Length, sn.Length);
            for (int i = 0; i < len; i++)
            {
                if (i < fn.Length && i < sn.Length)
                {
                    sum += fn[i] * sn[i];
                }
                else if (i < fn.Length)
                {
                    sum += fn[i];
                }
                else if (i < sn.Length)
                {
                    sum += sn[i];
                }
            }
            return sum;
        }
    }
}