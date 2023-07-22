using System.Xml.Linq;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Drinks> products = new Dictionary<string, Drinks>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] arguments = input.Split();
                string name = arguments[0];
                double price = double.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                Drinks drink = new Drinks(name, price, quantity);

                if (!products.ContainsKey(name))
                {
                    products[name] = drink;
                }
                else
                    products[name].Update(price, quantity);
            }

            foreach (KeyValuePair<string, Drinks> pair in products)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    public class Drinks
    {

        public Drinks(string name,double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public void Update(double price, int quantity)
        {
            Price = price;
            Quantity += quantity;
        }
        public double TotalPrice => Price * Quantity;

        public override string ToString()
        {
            return $"{Name} -> {TotalPrice:F2}";
        }
    }
}