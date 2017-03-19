using System;
using System.Globalization;

namespace _1SinoTheWalker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var startingTime = DateTime.ParseExact(
                Console.ReadLine(), "HH:mm:ss",
                CultureInfo.InvariantCulture);

            var numberOfSteps = int.Parse(Console.ReadLine());

            var secondsPerStep = int.Parse(Console.ReadLine());


            //long initialSeconds = startingTime.Hour * 60 * 60
            //    + startingTime.Minute * 60 + startingTime.Second;

            //long secondsToAdd = (long)numberOfSteps * (long)secondsPerStep;

            //long secondsToAddPerDay = secondsToAdd % (24 * 60 * 60);

            //var asd = secondsToAdd / (24 * 60 * 60);

            //var finalDate = startingTime.AddSeconds(secondsToAddPerDay);

            //Console.WriteLine($"Time Arrival: {finalDate:HH:mm:ss}");

            // Second Variant:

            //long initialSeconds = startingTime.Hour * 60 * 60 
            //    + startingTime.Minute * 60 + startingTime.Second;

            //long secondsToAdd = numberOfSteps * secondsPerStep;
            //var totalSeconds = initialSeconds + secondsToAdd;

            //var seconds = totalSeconds % 60;
            //var totalMinutes = totalSeconds / 60;

            //var minutes = totalMinutes % 60;
            //var totalHours = totalMinutes / 60;

            //var hours = totalHours % 24;

            //Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00} ");


            // First Variant:

            //for (int i = 0; i < numberOfSteps; i++)
            //{
            //    startingTime = startingTime.AddSeconds(secondsPerStep);
            //}

            //Console.WriteLine($"Time Arrival: {startingTime:HH:mm:ss}");

            //var result = startingTime.ToString("HH:mm:ss");
        }
    }
}
