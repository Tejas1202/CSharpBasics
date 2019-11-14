using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWithMoshConsoleApp
{
    class DateTimeIntro
    {
        public void IntroToDateTimeType()
        {
            var dateTime = new DateTime();
            Console.WriteLine(dateTime);
            var particularDateTime = new DateTime(1996, 03, 15);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour); //Accessing property with another property as DateTime.Now property is of DateTime type
            Console.WriteLine("Minute: " + now.Minute);

            var tommorow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine(string.Format("Tomorrow: {0}, Yesterday: {1}", tommorow, yesterday));

            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        public void TimeSpanIntro()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var duration = DateTime.Now - DateTime.Now.AddMinutes(3);
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Note: As TimeSpan is also immutable, both these methods below returns a new object
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
