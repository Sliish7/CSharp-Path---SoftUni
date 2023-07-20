namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main()
        {
            List<Person> list = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(' ');
                string name = arguments[0];
                string id = arguments[1];
                int age = int.Parse(arguments[2]);

                Person personExist = list.FirstOrDefault(x => x.ID == id);

                if (personExist != null)
                {
                    personExist.Age = age;
                    personExist.Name = name;
                }
                else
                    list.Add(new Person(name, id, age));
            }

            List<Person> orderedList = list.OrderBy(x => x.Age).ToList();

            foreach (Person person in orderedList)
            {
                Console.WriteLine(person);
            }
        } 
    }

    internal class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}