namespace _01.Ages
{
    internal class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            string person;

            if (age >= 66)
            {
                person = "elder";
            }
            else if (age >= 20)
            {
                person = "adult";
            }
            else if (age >= 14)
            {
                person = "teenager";
            }
            else if (age >= 3)
            {
                person = "child";
            }
            else
                person = "baby";

            Console.WriteLine(person);
        }
    }
}