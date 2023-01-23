using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            var vowels = new Dictionary<char, int>()
            {
                { 'a', 1 },
                { 'e', 2 },
                { 'i', 3 },
                { 'o', 4 },
                { 'u', 5 }
            };

            for (int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]);
                if (vowels.ContainsKey(c))
                {
                    sum += vowels[c];
                }
            }
            //foreach (char c in input)
            //{
            //    if (vowels.ContainsKey(char.ToLower(c)))
            //    {
            //        sum += vowels[char.ToLower(c)];              
            //    }
            //}
            Console.WriteLine(sum);
        }
    }
}
