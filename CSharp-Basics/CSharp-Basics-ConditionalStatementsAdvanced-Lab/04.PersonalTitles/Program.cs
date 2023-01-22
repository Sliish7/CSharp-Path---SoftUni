using System;
using System.Threading;

namespace _04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            string title = "";

            switch (sex)
            {
                case "f":
                    if (age < 16)
                    {
                        title = "Miss";
                        Console.WriteLine(title);
                    }
                    else
                    {
                        title = "Ms.";
                        Console.WriteLine(title);
                    }
                    break;
                case "m":
                    if (age < 16)
                    {
                        title = "Master";
                        Console.WriteLine(title);
                    }
                    else
                    {
                        title = "Mr.";
                        Console.WriteLine(title);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
