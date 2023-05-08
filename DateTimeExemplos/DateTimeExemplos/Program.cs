using System;
using System.Globalization;
using System.Security.Cryptography;

namespace DateTimeExemplos {
    class Program {
        static void Main(string[] args) {

            //DATETIME

            /* DateTime d1 = new DateTime(2023, 03, 17);

             DateTime d2 = new DateTime(2023, 03, 17, 18, 25, 31);

             DateTime d3 = new DateTime(2023, 03, 17, 18, 25, 31, 500);

             DateTime d4 = DateTime.Now;

             DateTime d5 = DateTime.Today;

             DateTime d6 = DateTime.UtcNow;

             DateTime d7 = DateTime.Parse("2000-08-15");

             DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

             DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

             Console.WriteLine(d1);
             Console.WriteLine(d2);
             Console.WriteLine(d3);
             Console.WriteLine(d4);
             Console.WriteLine(d5);
             Console.WriteLine(d6);
             Console.WriteLine(d7);
             Console.WriteLine(d8);
             Console.WriteLine(d9);
            */

            //TIMESPAN

            /* TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks); */

            //DATETIME KIND ISO 8601
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1 Kind: " + d1.Kind);
            Console.WriteLine("D1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("D1 to Utc: " + d1.ToUniversalTime());

            Console.WriteLine("D2: " + d2);
            Console.WriteLine("D2 Kind: " + d2.Kind);
            Console.WriteLine("D2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("D2 to Utc: " + d2.ToUniversalTime());

            Console.WriteLine("D3: " + d3);
            Console.WriteLine("D3 Kind: " + d3.Kind);
            Console.WriteLine("D3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("D3 to Utc: " + d3.ToUniversalTime());


        }
    }
}
