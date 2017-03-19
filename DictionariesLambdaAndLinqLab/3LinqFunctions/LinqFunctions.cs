using System;
using System.Linq;

namespace _3LinqFunctions
{
    public class LinqFunctions
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var arrayOfNumbers = new int [n];

            for (int number = 0; number < n; number++)
            {
                arrayOfNumbers[number] = int.Parse(Console.ReadLine());
            }
            var sum = arrayOfNumbers.Sum();
            var min = arrayOfNumbers.Min();
            var max = arrayOfNumbers.Max();
            var average = arrayOfNumbers.Average();

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Average = {0}", average);

        }
    }
}
