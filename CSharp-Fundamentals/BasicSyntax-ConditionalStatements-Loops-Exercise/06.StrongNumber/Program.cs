namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            char[] arrayDigits = number.ToString().ToCharArray();

            for (int i = 0; i < arrayDigits.Length; i++)
            {
                int currDigit = arrayDigits[i] - '0';
                int factorial = 1;

                for (int j = 1; j <= currDigit; j++)
                {
                    factorial *= j;
                }

                sum += factorial;
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}