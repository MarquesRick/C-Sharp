using System;
using System.Globalization;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

           // Demo - ParseExact
            DateTime f1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            CultureInfo.InvariantCulture);
            DateTime f2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
