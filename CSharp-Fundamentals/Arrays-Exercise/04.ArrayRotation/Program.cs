using System;
using System.Collections;
using System.Collections.Generic;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Queue<int> numbersQueue = new Queue<int>(numbers);
            int moveCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < moveCount; i++)
            {
                int currNum = numbersQueue.Dequeue();
                numbersQueue.Enqueue(currNum);
            }

            Console.WriteLine(string.Join(" ", numbersQueue));
        }
    }
}
