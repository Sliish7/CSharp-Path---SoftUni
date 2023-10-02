using System.Drawing;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobeColor = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ").ToArray();
                string color = tokens[0];
                string[] clothes = tokens[1].Split(",");

                if (!wardrobeColor.ContainsKey(color))
                {
                    wardrobeColor.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (wardrobeColor[color].ContainsKey(clothes[j]))
                    {
                        wardrobeColor[color][clothes[j]]++;
                    }
                    else
                        wardrobeColor[color][clothes[j]] = 1;
                }
            }

            string[] searchCommand = Console.ReadLine().Split(" ").ToArray();

            foreach (var kvpColor in wardrobeColor)
            {
                Console.WriteLine($"{kvpColor.Key} clothes:");
                Dictionary<string, int> clothes = kvpColor.Value;

                foreach (var kvpCloth in clothes)
                {
                    string found = (kvpColor.Key == searchCommand[0] && kvpCloth.Key == searchCommand[1]) ? " (found!)" : "";
                    Console.WriteLine($"* {kvpCloth.Key} - {kvpCloth.Value} {found}");
                }
            }
        }
    }
}