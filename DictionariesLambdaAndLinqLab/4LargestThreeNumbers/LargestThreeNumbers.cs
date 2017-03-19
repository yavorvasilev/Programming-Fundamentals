using System;
using System.Linq;

namespace _4LargestThreeNumbers
{
    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var listOfLargestThreeNumbers = listOfNumbers.OrderByDescending(x => x).Take(3);

            foreach (var number in listOfLargestThreeNumbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
