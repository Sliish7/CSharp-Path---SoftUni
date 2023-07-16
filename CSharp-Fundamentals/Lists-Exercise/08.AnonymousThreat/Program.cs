using System.Text;

namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();
            string arguments = string.Empty;

            while ((arguments = Console.ReadLine()) != "3:1")
            {
                string[] argsArr =  arguments.Split().ToArray();
                string command = argsArr[0];

                foreach (string item in list)
                {
                    item.Replace(" ", "");
                }

                switch (command)
                {
                    case "merge":
                        list = MergeItems(list, argsArr);
                        break;
                    case "divide":
                        list = DivideItem(list, argsArr);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static List<string> MergeItems(List<string> list, string[] argsArr)
        {
            int startIndex = int.Parse(argsArr[1]);
            int endIndex = int.Parse(argsArr[2]);
            if (endIndex >= list.Count)
            {
                endIndex = list.Count - 1;
            }

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > endIndex)
            {
                return list;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                list[startIndex] += list[startIndex + 1];
                list.RemoveAt(startIndex + 1);
            }

            return list;
        }

        private static List<string> DivideItem(List<string> list, string[] argsArr)
        {
            int index = int.Parse(argsArr[1]);
            int parts = int.Parse(argsArr[2]);
            string str = list[index];
            list.RemoveAt(index);

            int partLength = str.Length / parts;
            List<string> dividedParts = new List<string>();

            for (int i = 0; i < parts; i++)
            {
                string currPart = str.Substring(0, partLength);
                str = str.Substring(partLength);
                dividedParts.Add(currPart);
            }

            if (str != "")
            {
                dividedParts[dividedParts.Count - 1] += str;
            }

            dividedParts.Reverse();

            foreach (string i in dividedParts)
            {
                list.Insert(index, i);
            }


            return list;
        }
    }
}