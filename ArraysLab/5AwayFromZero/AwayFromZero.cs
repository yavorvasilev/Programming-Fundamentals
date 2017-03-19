using System;
using System.Linq;

namespace _5AwayFromZero
{
    public class AwayFromZero
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in arr)
            {
                Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
