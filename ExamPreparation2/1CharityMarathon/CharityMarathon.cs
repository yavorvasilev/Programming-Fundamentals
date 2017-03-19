using System;

namespace _1CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var daysOfMarathon = int.Parse(Console.ReadLine());

            var numberOfRunners = int.Parse(Console.ReadLine());

            var averageNumberOfLaps = int.Parse(Console.ReadLine());

            var lengthOfTheTrack = int.Parse(Console.ReadLine());

            var capacityOfTheTrack = int.Parse(Console.ReadLine());

            var donatedMoneyPerKm = decimal.Parse(Console.ReadLine());

            var maximumRunners = daysOfMarathon * capacityOfTheTrack;

            var participants = 0;

            if (maximumRunners <= numberOfRunners)
            {
                participants = maximumRunners;
            }
            else
            {
                participants = numberOfRunners;
            }

            decimal totalMeters = (decimal)participants * (decimal)averageNumberOfLaps * (decimal)lengthOfTheTrack;

            decimal totalKm = totalMeters / 1000;

            decimal donatedMoney = donatedMoneyPerKm * totalKm;

            Console.WriteLine($"Money raised: {donatedMoney:F2}");
        }
    }
}
