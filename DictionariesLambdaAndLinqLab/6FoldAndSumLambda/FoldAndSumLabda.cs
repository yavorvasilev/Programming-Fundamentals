using System;
using System.Linq;
using System.Collections.Generic;


namespace _6FoldAndSumLambda
{
    public class FoldAndSumLabda
    {
        public static void Main()
        {
            var sequenceOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var firstRow = new List<int>();
            var k = sequenceOfNumbers.Length / 4;
            var firstRowLeft = sequenceOfNumbers.Take(k).Reverse().ToList();
            var firstRowRight = sequenceOfNumbers.Reverse().Take(k).ToList();
            firstRowLeft.AddRange(firstRowRight);
            firstRow = firstRowLeft;
            var secondRow = sequenceOfNumbers.Skip(k).Take(2 * k).ToList();

            var sum = firstRow.Select((x, index) => x + secondRow[index]);

            Console.WriteLine(string.Join(" ",sum));

        }
    }
}
