namespace _11.TriFunction
{
    internal class Program
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string, int, bool> checkSum = (name, sum) => name.Sum(ch => ch) >= sum;
                //(name, sum) =>                    Easier to understand than that ^
                //{
                //    int charSum = name.Sum(ch => ch);
                //    return charSum >= sum;
                //};
            Func<string[], int, Func<string, int, bool>, string> getName = (names, sum, match) => names.FirstOrDefault(name => match(name, sum));
                //(names, sum, match) =>            Easier to understand than that ^
                //{
                //    foreach (var name in names)
                //    {
                //        if (match(name, sum))
                //        {
                //            return name;
                //        }
                //    }
                //    return default;
                //};
            string foundName = getName(names, sum, checkSum);
            Console.WriteLine(foundName);
        }
    }
}