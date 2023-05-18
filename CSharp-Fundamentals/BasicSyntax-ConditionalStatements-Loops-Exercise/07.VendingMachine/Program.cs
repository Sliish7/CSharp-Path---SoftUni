namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double total = 0;

            while (input != "Start")
            {
                total = CoinValidation(total, input);
                input = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {

                switch (product)
                {
                    case "Nuts":
                        double prodPrice = 2;
                        total = PriceCheck(prodPrice, total, product);
                        break;
                    case "Water":
                        prodPrice = 0.7;
                        total = PriceCheck(prodPrice, total, product);
                        break;
                    case "Crisps":
                        prodPrice = 1.5;
                        total = PriceCheck(prodPrice, total, product);
                        break;
                    case "Soda":
                        prodPrice = 0.8;
                        total = PriceCheck(prodPrice, total, product);
                        break;
                    case "Coke":
                        prodPrice = 1;
                        total = PriceCheck(prodPrice, total, product);
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {total:f2}");

        }

        static double CoinValidation(double total, string input)
        {
            double coin = double.Parse(input);
            if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
            {
                total += coin;
            }
            else if (input != "Start")
            {
                Console.WriteLine($"Cannot accept {input}");
            }
            return total;
        }

        static double PriceCheck(double prodPrice, double total, string product)
        {
            if (total >= prodPrice)
            {
                total -= prodPrice;
                Console.WriteLine($"Purchased {product.ToLower()}");
            }
            else
                Console.WriteLine("Sorry, not enough money");

            return total;
        }    
    }
}