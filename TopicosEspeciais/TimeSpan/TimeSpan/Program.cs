using System;

namespace Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            //Demo - métodos From
            TimeSpan r1 = TimeSpan.FromDays(1.5);
            TimeSpan r2 = TimeSpan.FromHours(1.5);
            TimeSpan r3 = TimeSpan.FromMinutes(1.5);
            TimeSpan r4 = TimeSpan.FromSeconds(1.5);
            TimeSpan r5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan r6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
