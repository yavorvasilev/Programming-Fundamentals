using System;
using System.Collections.Generic;
using System.Linq;

namespace _3EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var nameOfDrivers = Console.ReadLine().Split(new[] { ' ' }
            ,StringSplitOptions.RemoveEmptyEntries).ToArray();

            var trackLayout = Console.ReadLine().Split(new[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            var checkpointIndexes = Console.ReadLine().Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //var drivers = new Dictionary<string, Dictionary<string, decimal>>();

            for (int i = 0; i < nameOfDrivers.Length; i++)
            {
                var fuel = (decimal)nameOfDrivers[i][0];

                for (int index = 0; index < trackLayout.Length; index++)
                {
                    if (checkpointIndexes.Contains(index))
                    {
                        fuel += trackLayout[index];
                    }
                    else
                    {
                        fuel -= trackLayout[index];
                    }

                    if (fuel > 0)
                    {
                        continue;
                    }
                    else
                    {
                        //drivers[nameOfDrivers[i]] = new Dictionary<string, decimal>();
                        //drivers[nameOfDrivers[i]]["reached"] = index;
                        //break;

                        Console.WriteLine($"{nameOfDrivers[i]} - reached {index}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    //drivers[nameOfDrivers[i]] = new Dictionary<string, decimal>();
                    //drivers[nameOfDrivers[i]]["fuel left"] = fuel;
                    Console.WriteLine($"{nameOfDrivers[i]} - fuel left {fuel:F2}");
                }
            }
            //Console.WriteLine();

            //foreach (var driver in drivers)
            //{
            //    Console.Write($"{driver.Key} - ");
            //    foreach (var distance in driver.Value)
            //    {
            //        if (distance.Key == "reached")
            //        {
            //            Console.WriteLine($"{distance.Key} {distance.Value}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{distance.Key} {distance.Value:F2}");
            //        }
            //    }
            //}
        }
    }
}
