using System;

namespace _07.String_Explosion
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            int strength = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '>')
                {
                    strength += chars[i + 1]; 
                }

                
            }
        }
    }
}