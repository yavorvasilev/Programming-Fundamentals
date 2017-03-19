﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceInMeters = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            var meterInSeconds = (float)distanceInMeters / (float)(hours * 3600 + minutes * 60 + seconds);
            var kilometersPerHour = (distanceInMeters / 1000) / (hours + minutes / 60 + seconds / 3600);
            var milesPerHour = (distanceInMeters / 1609) / ((hours + minutes / 60 + seconds / 3600));

            Console.WriteLine("{0}\n{1}\n{2}", meterInSeconds, kilometersPerHour, milesPerHour);
        }
    }
}
