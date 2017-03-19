using System;
using System.Globalization;

namespace _1CountWorkingDays
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            // 27-12-2015
            // 05-01-2016
            var startDateAsString = Console.ReadLine();
            var endDateAsString = Console.ReadLine();

            var startDate = DateTime.ParseExact(startDateAsString, "dd-MM-yyyy",CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(endDateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            //var year = startDate.Year;

            var holidays = new DateTime[11];

            holidays[0] = DateTime.ParseExact($"01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[1] = DateTime.ParseExact($"03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[2] = DateTime.ParseExact($"01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[3] = DateTime.ParseExact($"06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[4] = DateTime.ParseExact($"24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[5] = DateTime.ParseExact($"06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[6] = DateTime.ParseExact($"22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[7] = DateTime.ParseExact($"01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[8] = DateTime.ParseExact($"24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[9] = DateTime.ParseExact($"25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            holidays[10] = DateTime.ParseExact($"26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidaysCounter = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                //Console.WriteLine(date);
                //date = date.AddDays(1);

                //var dayOfweek = date.DayOfWeek.ToString();
                //Console.WriteLine($"{dayOfweek} - {date}");
                DateTime checkDate = new DateTime(2016, date.Month, date.Day);

                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCounter++;
                }
                else
                {
                    if (checkDate == holidays[0] || checkDate == holidays[1] || checkDate == holidays[2]
                   || checkDate == holidays[3] || checkDate == holidays[4] || checkDate == holidays[5] || checkDate == holidays[6]
                   || checkDate == holidays[7] || checkDate == holidays[8] || checkDate == holidays[9] || checkDate == holidays[10])
                    {
                        holidaysCounter++;
                    }
                }
               
                //Console.WriteLine(holidaysCounter);
            }
            var allDays = (endDate - startDate).TotalDays + 1;
            //Console.WriteLine(allDays);
            //Console.WriteLine(holidaysCounter);
            Console.WriteLine(allDays - holidaysCounter);
        }
    }
}
