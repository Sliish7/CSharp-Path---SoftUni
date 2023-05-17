namespace _01.Ages
{
    internal class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            string person;

            if (age < 3)
            {
                person = "baby";
            }
            else if (age < 14)
            {
                person = "child";
            }
            else if (age < 20)
            {
                person = "teenager";
            }
            else if (age < 66)
            {
                person = "adult";
            }
            else
                person = "elder";

            Console.WriteLine(person);
        }
    }
}