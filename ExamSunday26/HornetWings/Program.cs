using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = long.Parse(Console.ReadLine());

            var distanceFor1000Flaps = decimal.Parse(Console.ReadLine());

            var flapsAfterStopFor5s = long.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceFor1000Flaps;

            var time = wingFlaps / 100;

            var restTime = (wingFlaps / flapsAfterStopFor5s) * 5;

            var totalTime = time + restTime;

            Console.WriteLine($"{distance:F2} m.");

            Console.WriteLine($"{totalTime} s.");




        }
    }
}
