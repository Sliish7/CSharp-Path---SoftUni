using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookToFind = Console.ReadLine();
            string book = Console.ReadLine();
            bool isFound = false;
            int bookCounter = 0;

            while (book != "No More Books")
            {
                if (bookToFind == book)
                {
                    isFound = true;
                    break;
                }
                else
                {
                    bookCounter++;
                    book = Console.ReadLine();
                }
            }

            if (isFound != true)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
            else
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
        }
    }
}
