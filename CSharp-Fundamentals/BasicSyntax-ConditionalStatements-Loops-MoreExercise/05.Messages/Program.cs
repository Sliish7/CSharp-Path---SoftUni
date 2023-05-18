namespace _05.Messages
{
    internal class Program
    {
        static void Main()
        {
            int numOfLett = int.Parse(Console.ReadLine());
            int wordCount = 0;
            string sentence = "";

            while (wordCount != numOfLett)
            {
                int letter = int.Parse(Console.ReadLine());

                sentence += Letter(letter);
                wordCount++;
            }

            Console.WriteLine(sentence);
        }

        static string Letter(int letter)
        {
            return letter switch
            {
                2 => "a",
                22 => "b",
                222 => "c",
                3 => "d",
                33 => "e",
                333 => "f",
                4 => "g",
                44 => "h",
                444 => "i",
                5 => "j",
                55 => "k",
                555 => "l",
                6 => "m",
                66 => "n",
                666 => "o",
                7 => "p",
                77 => "q",
                777 => "r",
                7777 => "s",
                8 => "t",
                88 => "u",
                888 => "v",
                9 => "w",
                99 => "x",
                999 => "y",
                9999 => "z",
                0 => " ",
                _ => ""
            };

        }
    }
}