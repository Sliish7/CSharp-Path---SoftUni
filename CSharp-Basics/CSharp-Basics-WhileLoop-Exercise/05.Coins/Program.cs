﻿using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double stotinki = Math.Round(input * 100);
            int coin = 0;

            while (stotinki > 0)
            {
                if (stotinki >= 200) 
                {
                    stotinki -= 200;
                }
                else if (stotinki >= 100)
                {
                    stotinki -= 100;
                }
                else if (stotinki >= 50)
                {
                    stotinki -= 50;
                }
                else if (stotinki >= 20)
                {
                    stotinki -= 20;
                }
                else if (stotinki >= 10)
                {
                    stotinki -= 10;
                }
                else if (stotinki >= 5)
                {
                    stotinki -= 5;
                }
                else if (stotinki >= 2)
                {
                    stotinki -= 2;
                }
                else
                {
                    stotinki -= 1;
                }

                coin++;
            }

            Console.WriteLine(coin);
        }
    }
}
