namespace _04.Students
{
    internal class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ");
                string firstName = personInfo[0];
                string lastName = personInfo[1];
                decimal grade = decimal.Parse(personInfo[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }

            
        }
        public class Student
        {
            public Student(string firstName, string lastName, decimal grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public decimal Grade { get; set; }
        }
    }
}