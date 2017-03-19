using System;
using System.Collections.Generic;
using System.Linq;

namespace _6SquareNumbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            listOfNumbers.RemoveAll(x=> Math.Sqrt(x) != (int) Math.Sqrt(x));
            listOfNumbers.Sort();
            listOfNumbers.Reverse();

            Console.WriteLine(string.Join(" ", listOfNumbers));

        
        }
    }
}
