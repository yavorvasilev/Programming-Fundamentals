using System;
using System.Collections.Generic;
using System.Linq;

namespace testList
{
    public class testList
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sequence = new List<int>();
            var maxSequence = new List<int>();
            var finalList = new List<int>();
            var sum = 0;
            var maxSum = 0;

            sequence.Add(listOfNumbers[0]);
            for (int i = 0; i < listOfNumbers.Count - 1; i++)
            {
                if (listOfNumbers[i] < listOfNumbers[i + 1])
                {
                    sequence.Add(listOfNumbers[i + 1]);
                }
            }

           
        }
    }
}
