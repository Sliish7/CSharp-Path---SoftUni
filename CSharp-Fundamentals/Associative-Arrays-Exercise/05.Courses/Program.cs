namespace _05.Courses
{
    internal class Program
    {
        static void Main()
        {
            string input;
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(":");
                string course = arguments[0].Trim();
                string name = arguments[1].Trim();

                if (!courses.ContainsKey(course))
                {
                   courses.Add(course, new List<string>());
                }

                courses[course].Add(name);
            }

            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()}");
                Console.WriteLine("-- " + string.Join("\n-- ", kvp.Value));
            }
        }
    }
}