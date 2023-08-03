using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            decimal totalPrice = 0;
            List<string> furnitures = new List<string>();


            while (input != "Purchase")
            {              

                string pattern = @">>(?<furniture>[A-z]+)<<(?<price>(\d+\.\d+|\d+))!(?<quantity>\d+)";
                MatchCollection matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    furnitures.Add(match.Groups["furniture"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
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