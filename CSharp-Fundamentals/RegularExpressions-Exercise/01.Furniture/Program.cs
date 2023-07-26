using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double totalPrice = 0;
            List<string> furnitures = new List<string>();


            while (input != "Purchase")
            {              

                string pattern = @">>(?<furniture>\w+)<<(?<price>[\d.]+)!(?<quantity>\d+)";
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    furnitures.Add(match.Groups["furniture"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    totalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (string furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}