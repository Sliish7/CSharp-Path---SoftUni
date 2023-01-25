﻿using System;
using System.Runtime.InteropServices;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string n = Console.ReadLine();
            int max = int.MinValue;
            int num = 0;

            while (n != "Stop")
            {
                num = Convert.ToInt32(n);
                if (num > max)
                {
                    max = num;
                }
                n = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
