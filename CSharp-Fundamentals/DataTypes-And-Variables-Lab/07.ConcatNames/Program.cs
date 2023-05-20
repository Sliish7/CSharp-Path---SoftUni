namespace _07.ConcatNames
{
    internal class Program
    {
        static void Main()
        {
            string fName = Console.ReadLine();
            string sName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine(String.Join(delimeter, fName, sName));
        }
    }
}