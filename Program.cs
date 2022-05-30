using System;

namespace DateTimeEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = today.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString ());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //Timespan examples

            //Creating 

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: = " + duration);

            //Properties

            Console.WriteLine("Minutes: "+ timeSpan.Minutes);
            Console.WriteLine("Totla Minutes: " + timeSpan.TotalMinutes);

            //Add and subtract

            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString

            Console.WriteLine("To String" + timeSpan.ToString());
        
            //Parse

            Console.WriteLine("Parse: "+ TimeSpan.Parse("01:02:03"));    
        }
    }
}
