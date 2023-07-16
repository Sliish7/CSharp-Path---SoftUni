using System.ComponentModel;

namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main()
        {
/*1, Yolo, 3, 4, 5, 6
Exercise:Yolo
Add:Database
Swap:Yolo:Database*/

            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string args = "";

            while ((args = Console.ReadLine()) != "course start")
            {
                string command = args.Split(':')[0];

                switch (command)
                {
                    case "Add":
                        AddCourse(lessons, args);
                        break;
                    case "Insert":
                        InsertCourse(lessons, args);
                        break;
                    case "Remove":
                        RemoveCourse(lessons, args);
                        break;
                    case "Swap":
                        SwapCourse(lessons, args);
                        break;
                    case "Exercise":
                        AddExercise(lessons, args);
                        break;
                }

                Console.WriteLine(string.Join(" ", lessons));
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                int count = 1;

                Console.WriteLine($"{count + i}.{lessons[i]}");
            }
        }

        private static List<string> AddExercise(List<string> lessons, string args)
        {
            string ExerciseTitle = args.Split(':')[1];
            if (lessons.Contains(ExerciseTitle) && !lessons.Contains(ExerciseTitle + "-Exercise"))
            {
                int indexOfExercise = lessons.IndexOf(ExerciseTitle) + 1;
                lessons.Insert(indexOfExercise ,ExerciseTitle + "-Exercise");
            }
            else if (!lessons.Contains(ExerciseTitle))
            {
                AddCourse(lessons, args);
                lessons.Add(ExerciseTitle + "-Exercise");
            }

            return lessons;
        }

        private static List<string> AddCourse(List<string> lessons, string args)
        {
            string title = args.Split(':')[1];
            if (!lessons.Contains(title))
            {
                lessons.Add(title);
            }
            return lessons;
        }

        private static List<string> InsertCourse(List<string> lessons, string args)
        {
            string title = args.Split(':')[1];
            int index = int.Parse(args.Split(':')[2]);
            if (!lessons.Contains(title) && index >= 0 && index <= lessons.Count)
            {
                lessons.Insert(index, title);
            }
            return lessons;
        }

        private static List<string> RemoveCourse(List<string> lessons, string args)
        {
            string title = args.Split(':')[1];
            if (lessons.Contains(title) && lessons.Contains(title + "-Exercise"))
            {
                lessons.Remove(title);
                lessons.Remove(title + "-Exercise");
            }
            else if (lessons.Contains(title))
            {
                lessons.Remove(title);
            }

            return lessons;
        }

        private static List<string> SwapCourse(List<string> lessons, string args)
        {
            string firstTitle = args.Split(':')[1];
            string secondTitle = args.Split(':')[2];

            if (lessons.Contains(firstTitle) && lessons.Contains(secondTitle))
            {
                string temp = firstTitle;
                string tempexercise = "";

                int index1 = lessons.IndexOf(firstTitle);
                int index2 = lessons.IndexOf(secondTitle);

                lessons[index1] = lessons[index2];
                lessons[index2] = temp;

                if (lessons.Contains(firstTitle + "-Exercise") && lessons.Contains(secondTitle + "-Exercise"))
                {
                    tempexercise = firstTitle + "-Exercise";
                    lessons[index1 + 1] = lessons[index2 + 1];
                    lessons[index2 + 1] = tempexercise;
                }
                else if (lessons.Contains(firstTitle + "-Exercise"))
                {
                    tempexercise = lessons[index1 + 1];
                    lessons.Insert(index2 + 1, tempexercise);
                    lessons.RemoveAt(index1 + 1);
                }
                else if (lessons.Contains(secondTitle + "-Exercise"))
                {
                    tempexercise = lessons[index2 + 1];
                    lessons.RemoveAt(index2 + 1);
                    lessons.Insert(index1 + 1, tempexercise);
                }
            }
            return lessons;
        }
    }
}