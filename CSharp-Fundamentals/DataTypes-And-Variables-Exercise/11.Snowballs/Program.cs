using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main()
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger bisSnowball = int.MinValue;
            string output = "";

            while (snowballs != 0)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snow / time), quality);

                if (value >= bisSnowball)
                {
                    bisSnowball = value;
                    output = $"{snow} : {time} = {value} ({quality})";
                }
                snowballs--;
            }
           
            Console.WriteLine(output);
        }
    }
}