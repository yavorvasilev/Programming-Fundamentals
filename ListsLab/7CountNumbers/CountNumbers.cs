using System;
using System.Linq;

namespace _7CountNumbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            listOfNumbers.Sort();
            //var ascendingList =  listOfNumbers.OrderBy(x => x).ToList();
            //var descendingList = listOfNumbers.OrderByDescending(x => x).ToList();
            Console.WriteLine($"{listOfNumbers[0]} -> {listOfNumbers.Count(x => x == listOfNumbers[0])}");
            for (int number = 1; number < listOfNumbers.Count; number++)
            {
                if (listOfNumbers[number - 1] != listOfNumbers[number])
                {
                    Console.WriteLine($"{listOfNumbers[number]} -> {listOfNumbers.Count(x => x == listOfNumbers[number])}");
                }
            }
        }
    }
}
