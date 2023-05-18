namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main()
        {
            int losesCount = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double expenses = 0;

            //counters added
            //int cH = 0;
            //int cM = 0;
            //int cD = 0;
            int cK = 0;

            for (int i = 1; i <= losesCount; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    expenses += mousePrice + keyboardPrice + headsetPrice;

                    cK ++;
                    //cM++; cH++;
                    
                }
                else if (i % 2 == 0)
                {
                    expenses += headsetPrice;
                    //cH++;
                }
                else if (i % 3 == 0)
                {
                    expenses += mousePrice;
                    //cM++;
                }

                if (cK % 2 == 0 && cK != 0)
                {
                    expenses += displayPrice;
                    //cD++;
                    cK = 0;
                }
            }


            //Console.WriteLine($"Headset > {cH}\n" +
            //                    $"Mouse > {cM}\n" +
            //                    $"KeyBoard > {cK}\n" +
            //                    $"Display > {cD}");
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}