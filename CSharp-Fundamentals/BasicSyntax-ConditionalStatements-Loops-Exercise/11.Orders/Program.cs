namespace _11.Orders
{
    internal class Program
    {
        static void Main()
        {
            int orders = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            while (orders != 0)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                double coffeePrice = ((days * capsuleCount) * capsulePrice);
                totalPrice+= coffeePrice;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");

                orders--;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}