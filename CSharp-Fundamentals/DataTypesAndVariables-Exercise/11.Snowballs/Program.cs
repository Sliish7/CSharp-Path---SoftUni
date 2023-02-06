using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //Using BigInteger so we can handle bigger powers
            BigInteger highestValue = 0;
            //Keeping the data of the highest value snowball.
            int sbSnow = 0;
            int sbTime = 0;
            int sbQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int currSBsnow = int.Parse(Console.ReadLine());
                int currSBtime = int.Parse(Console.ReadLine());
                int currSBquality = int.Parse(Console.ReadLine());
                BigInteger currSBValue = BigInteger.Pow(currSBsnow / currSBtime, currSBquality);

                if (currSBValue > highestValue)
                {
                    highestValue = currSBValue;
                    sbSnow = currSBsnow;
                    sbTime = currSBtime;
                    sbQuality = currSBquality;
                }
            }

            Console.WriteLine($"{sbSnow} : {sbTime} = {highestValue} ({sbQuality})");
        }
    }
}
