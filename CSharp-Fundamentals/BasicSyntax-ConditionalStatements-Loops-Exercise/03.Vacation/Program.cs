namespace _03.Vacation
{
    internal class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfVac = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0; ; double totalPrice = 0;

            switch (typeOfVac)
            {
                case "Students":                    

                    if (dayOfTheWeek == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 10.46;
                    }

                    totalPrice = people * price;

                    if (people >= 30)
                    {
                        totalPrice *= 0.85;
                    }

                    break;
                case "Business":

                    if (dayOfTheWeek == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 16;
                    }

                    if (people < 100)
                    {
                        totalPrice = people * price;
                    }
                    else
                        totalPrice = (people - 10) * price;

                    break;
                case "Regular":

                    if (dayOfTheWeek == "Friday")
                    {
                        price = 15;
                    }
                    else if (dayOfTheWeek == "Saturday")
                    {
                        price = 20;
                    }
                    else if (dayOfTheWeek == "Sunday")
                    {
                        price = 22.50;
                    }

                    totalPrice = people * price;

                    if (people >= 10 && people <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}