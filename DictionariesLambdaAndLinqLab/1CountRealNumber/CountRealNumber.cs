using System;
using System.Collections.Generic;
using System.Linq;

namespace _1CountRealNumber
{
    public class CountRealNumber
    {
        public static void Main()
        {
            var counts = new SortedDictionary<double, int>();
            var inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in inputNumbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 1;
                }
                else
                {
                    counts[number] += 1;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }

}