using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalTickets = 0;
            double studentsT = 0;
            double standartT = 0;
            double kidsT = 0;

            while (movie != "Finish")
            {
                int spots = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                int currMovieTickets = 0;

                while (type != "End")
                {
                    switch (type)
                    {
                        case "student": studentsT++; break;
                        case "standard": standartT++; break;
                        case "kid": kidsT++; break;
                    }
                    totalTickets++;
                    currMovieTickets++;
                    bool isFull = false;

                    if (currMovieTickets == spots)
                    {
                        break;
                    }
                    else if (isFull == false)
                    {
                        type = Console.ReadLine();
                    }
                    else
                    currMovieTickets = 0;
                }
                double percentageFull = (double)currMovieTickets / spots * 100;

                Console.WriteLine($"{movie} - {percentageFull:f2}% full.");
                movie = Console.ReadLine();
            }
            studentsT = studentsT / totalTickets * 100;
            standartT = standartT / totalTickets * 100;
            kidsT = kidsT/ totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}\n{studentsT:f2}% student tickets.\n{standartT:f2}% standard tickets.\n{kidsT:f2}% kids tickets.");
        }
    }
}
