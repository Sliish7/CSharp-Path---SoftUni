namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine("String len:" + str.Length);
            int divide = int.Parse(Console.ReadLine());
            List<string> output = SplitStringEvenly(str, divide);
            Console.WriteLine(string.Join(",", output));

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        static List<string> SplitStringEvenly(string str, int divide) //works perfectly
        {
            List<string> dividedParts = new List<string>();
            str = str.Replace(" ", "");
            int length = str.Length;
            int numParts = length / divide;
            Console.WriteLine(numParts);

            for (int i = 0; i < numParts; i++)
            {
                string part = str.Substring(i * divide, divide);
                dividedParts.Add(part);
            }

            string remainingPart = str.Substring(numParts * divide);
            if (!string.IsNullOrEmpty(remainingPart))
            {
                dividedParts.Add(remainingPart);
            }
            return dividedParts;
        }
    }
}