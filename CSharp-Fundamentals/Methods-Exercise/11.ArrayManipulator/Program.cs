using System.Collections.Immutable;
using System.Xml.Linq;

namespace _11.ArrayManipulator
{
//    internal class Program
//    {
//        static void Main()
//        {

//            //todo Max/Min method & first/last method
//            string integers = Console.ReadLine();

//            string input = Console.ReadLine();
//            while (input != "end")
//            {
//                string command = input.Substring(0, input.IndexOf(' '));

//                if (command == "exchange")
//                {
//                    integers = ExchangeCommand(integers, command, input);
//                }

//                input= Console.ReadLine();
//            }
//        }

//        private static string ExchangeCommand(string integers, string command, string input)
//        {
//            int index = int.Parse(input.Substring(input.IndexOf(" ")));  //Working perfectly Exchange command well not perfectly / Trqbwa da e s array zaradi chislata s dve/tri i tn cifri 10 100 1000
//            integers = integers.Replace(" ", "");

//            if (index < integers.Length && index >= 0)
//            {
//                string firstHalf = integers.Substring(0, index + 1);
//                string secondHalf = integers.Substring(index + 1);
//                integers = secondHalf + firstHalf;

//                string result = String.Join(" ", integers);
//                Console.WriteLine(result);
//            }
//            else
//                Console.WriteLine("Invalid index");

//            return integers;
//        }
//    }
//}