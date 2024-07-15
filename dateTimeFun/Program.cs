using System;

namespace DateTimeFun
{
    class Program
    {
        static void Main(string[] args)
        {
            var datetime = new DateTime(2024,7,15);

            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            Console.WriteLine("Today: " + now.TimeOfDay);

            var tomorrow = now.AddDays(2);
            var dayBeforeYesterday = now.AddDays(-2);

            Console.WriteLine("Tomorrow: " + tomorrow);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("O"));
            Console.WriteLine(now.ToString("yyyy-MM-dd-ddd"));




        }
    }
}