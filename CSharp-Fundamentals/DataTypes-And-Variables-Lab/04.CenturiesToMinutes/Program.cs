namespace _04.CenturiesToMinutes
{
    internal class Program
    {
        static void Main()
        {
            //365.2422
            int centuriesCount = int.Parse(Console.ReadLine());
            int years = centuriesCount * 100;
            int days = (int)(years * 365.2422m);
            int hours = (int)days * 24;
            int minutes = hours * 60;

            string output = $"{centuriesCount} centuries = {years} " +
                            $"years = {days} days = {hours} hours" +
                            $" = {minutes} minutes";

            Console.WriteLine(output);
        }
    }
}