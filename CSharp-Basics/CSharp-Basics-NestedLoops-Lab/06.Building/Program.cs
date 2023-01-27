using System;

namespace _06.Building
{
    internal class Program
    {
        static void Main()
        {
            int levels = int.Parse(Console.ReadLine());
            int apPerLevel = int.Parse(Console.ReadLine());

            for (int lvl = levels; lvl >= 1; lvl--)
            {
                string type = "";
                if (lvl == levels)
                {
                    type = "L";
                }
                else if (lvl % 2 == 0)
                {
                    type = "O";
                }
                else
                    type = "A";

                for (int ap = 0; ap < apPerLevel; ap++)
                {
                    Console.Write($"{type}{lvl}{ap} ");
                }
                Console.WriteLine();
            }

        }
    }
}
