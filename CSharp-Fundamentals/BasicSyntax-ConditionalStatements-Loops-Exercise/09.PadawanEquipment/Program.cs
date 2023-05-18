namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            double saberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            saberPrice = Math.Ceiling(students * 1.10) * saberPrice;
            robesPrice = students * robesPrice;
            beltsPrice= (students - (students / 6)) * beltsPrice;

            double total = saberPrice + robesPrice + beltsPrice;

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
                Console.WriteLine($"John will need {total - money:f2}lv more.");
        }
    }
}