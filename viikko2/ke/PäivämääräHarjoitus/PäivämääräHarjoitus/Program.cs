using System;

namespace PäivämääräHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DateTime date = DateTime.Today;
                Console.WriteLine(date.DayOfWeek);
                Console.WriteLine(date.AddDays(1).DayOfWeek);
                if(date.DayOfWeek == DayOfWeek.Friday)
                {
                    Console.WriteLine($"Seuraava perjantai 13. on {date.ToShortDateString()}");
                    break;
                }
                Console.WriteLine("n");
                date.AddDays(1);
            }
        }
    }
}
