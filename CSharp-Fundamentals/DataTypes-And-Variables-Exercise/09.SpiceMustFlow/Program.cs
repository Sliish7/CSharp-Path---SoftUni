namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalAmount = 0;

            while (startingYield >= 100)
            {
                totalAmount += startingYield - 26;
                startingYield -= 10;
                days++;
            }
            if (days > 0) 
            {
            totalAmount -= 26;        
            }
            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}