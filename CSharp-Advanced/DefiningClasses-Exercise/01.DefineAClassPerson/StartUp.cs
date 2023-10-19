namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Person> pOver30 = new();
            int pCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pCount; i++)
            {
                string[] personProps = Console.ReadLine()
                    .Split(" ");

                Person person = new(personProps[0], int.Parse(personProps[1]));

                if (person.Age > 30)
                {
                    pOver30.Add(person);
                }
            }


            foreach (var person in pOver30.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}