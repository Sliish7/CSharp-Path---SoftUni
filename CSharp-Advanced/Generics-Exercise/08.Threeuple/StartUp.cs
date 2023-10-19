namespace _08.Threeuple
{
    internal class StartUp
    {
        static void Main()
        {
            string[] personTokens = Console.ReadLine().Split(" ");
            string[] drinkTokens = Console.ReadLine().Split(" ");
            string[] numbersTokens = Console.ReadLine().Split(" ");

            Threeuple<string, string, string> person = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));
            Threeuple<string, int, bool> drink = new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");
            Threeuple<string, double, string> bankAccount = new(numbersTokens[0], double.Parse(numbersTokens[1]), numbersTokens[2]);

            Console.WriteLine(person);
            Console.WriteLine(drink);
            Console.WriteLine(bankAccount);
        }
    }
}