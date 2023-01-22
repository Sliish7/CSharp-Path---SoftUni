using System;

namespace _08.OnTimefortheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int examminutes = examHour * 60 + examMin;
            int arrivalminutes = arrivalHour * 60 + arrivalMin;
            int lateorno = examminutes - arrivalminutes;
            string status = "";

            if (lateorno < 0)
            {
                status = "Late";
            }
            else if (lateorno >= 0 && lateorno <= 30)
            {
                status = "On time";
            }
            else
            {
                status = "Early";
            }
            Console.WriteLine(status);

            if (lateorno < 0)
            {
                lateorno = Math.Abs(lateorno);

                if (lateorno / 60 <= 0 )
                {
                    Console.WriteLine($"{lateorno % 60} minutes after the start");
                }
                else if (lateorno / 60 >= 1)
                {
                    if (lateorno % 60 < 10)
                    {
                        Console.WriteLine($"{lateorno / 60}:0{lateorno % 60} hours after the start");
                    }
                    else
                    Console.WriteLine($"{lateorno / 60}:{lateorno % 60} hours after the start");
                }
                else
                Console.WriteLine($"{lateorno / 60}:{lateorno % 60} hours after the start");
            }
            else if (lateorno == 0){}
            else
            {
                if (lateorno / 60 <= 0)
                {
                    Console.WriteLine($"{lateorno % 60} minutes before the start");
                }
                else
                {
                    if (lateorno / 60 >= 1)
                    {
                        if (lateorno % 60 < 10)
                        {
                            Console.WriteLine($"{lateorno / 60}:0{lateorno % 60} hours before the start");
                        }
                        else
                        Console.WriteLine($"{lateorno / 60}:{lateorno % 60} hours before the start");
                    }
                    else
                    Console.WriteLine($"{lateorno / 60}:{lateorno % 60} hours before the start");
                }
                    
            }

        }
    }
}
