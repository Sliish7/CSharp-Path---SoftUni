namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            int[] specialNum = { 5, 7, 11 };
            
            int range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                int num = i;
                bool isSpecial = false;

                string currSum = num.ToString();
                int result = 0;

                for (int k = 0; k < currSum.Length; k++)
                {
                    result += currSum[k] - '0';
                }

                for (int j = 0; j < specialNum.Length; j++)
                {
                    if (result == specialNum[j])
                    {
                        isSpecial = true;
                    }
                }
                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}