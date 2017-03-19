using System;
using System.Globalization;

namespace _1DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            var day = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy",CultureInfo.InvariantCulture);

            Console.WriteLine(day.DayOfWeek);
        }
    }
}
