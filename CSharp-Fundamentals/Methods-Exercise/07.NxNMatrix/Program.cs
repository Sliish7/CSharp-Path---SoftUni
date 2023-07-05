namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main()
        {
            int filler = int.Parse(Console.ReadLine());
            Console.WriteLine(NxNMatrix(filler));
        }

        private static string NxNMatrix(int filler)
        {
            string output = string.Empty;
            for (int i = 0; i < filler; i++)
            {
                for (int j = 0; j < filler; j++)
                {
                    output += filler + " ";
                }
                output += "\n";
            }

            return output;
        }
    }
}