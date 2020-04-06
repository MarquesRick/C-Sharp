using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            //Formatação DateTime
            DateTime f = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = f.ToLongDateString();
            string s2 = f.ToLongTimeString();
            string s3 = f.ToShortDateString();
            string s4 = f.ToShortTimeString();
            string s5 = f.ToString();
            string s6 = f.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = f.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            //Operações com DateTime

            TimeSpan a = new TimeSpan(1, 12, 15, 16);
            DateTime x = DateTime.Now;
            DateTime y = x.Add(a);
            DateTime z = x.AddDays(1);
            DateTime b = x.AddHours(20);
            DateTime n = x.AddMilliseconds(20);
            DateTime u = x.AddMinutes(30);
            DateTime r = x.AddMonths(1);
            DateTime o = x.AddSeconds(40);
            DateTime l = x.AddTicks(300);
            DateTime p = x.AddYears(3);
            DateTime q = x.Subtract(a);
            TimeSpan t = x.Subtract(y);
        }
    }
}
