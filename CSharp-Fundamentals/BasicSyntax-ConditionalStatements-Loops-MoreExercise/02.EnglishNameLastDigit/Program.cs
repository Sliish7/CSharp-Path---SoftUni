namespace _02.EnglishNameLastDigit
{
    internal class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int lastDig = 0;
            string spelling = "zz";

            char[] digitArray = number.ToCharArray();

            for (int i = 0; i < digitArray.Length; i++)
            {
                if (i == digitArray.Length - 1)
                {
                    lastDig = digitArray[i] - '0';
                }
            }

            switch (lastDig)
            {
                case 0: spelling = "zero"; break;
                case 1: spelling = "one"; break;
                case 2: spelling = "two"; break;
                case 3: spelling = "three"; break;
                case 4: spelling = "four"; break;
                case 5: spelling = "five"; break;
                case 6: spelling = "six"; break;
                case 7: spelling = "seven"; break;
                case 8: spelling = "eight"; break;
                case 9: spelling = "nine"; break;
                default:break;
            }

            Console.WriteLine(spelling);
        }
    }
}