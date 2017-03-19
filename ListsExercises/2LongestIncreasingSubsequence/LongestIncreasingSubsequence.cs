using System;
using System.Collections.Generic;
using System.Linq;

namespace _2LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {

            // 3 5 8 -1 0 6 7
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sequence = new List<int>();
            var maxSequence = new List<int>();
            var sum = 0;
            var maxSum = 0;
            sequence.Add(listOfNumbers[0]);
            for (int i = 0; i < listOfNumbers.Count - 1; i++)
            {

                for (int j = i; j < listOfNumbers.Count - 1; j++)
                {
                    if (sequence[j] < listOfNumbers[j + 1])
                    {
                        sequence.Add(listOfNumbers[j + 1]);
                    }
                }

                sum = sequence.Sum();
                maxSum = maxSequence.Sum();
                if (sequence.Count > maxSequence.Count)
                {
                    maxSequence = new List<int>();
                    maxSequence.AddRange(sequence);
                    maxSum = 0;
                }
                else if (sequence.Count == maxSequence.Count && sum > maxSum)
                {
                    maxSequence = new List<int>();
                    maxSequence.AddRange(sequence);
                    maxSum = 0;
                }

                sequence.RemoveAll(x => x > listOfNumbers[i + 1]);
                sequence.Add(listOfNumbers[i + 1]);
                sum = 0;








                //if (listOfNumbers[i] < listOfNumbers[i + 1])
                //{
                //    sequence.Add(listOfNumbers[i + 1]);
                //}
                //else
                //{
                //    sum = sequence.Sum();
                //    maxSum = maxSequence.Sum();
                //    if (sequence.Count > maxSequence.Count)
                //    {
                //        maxSequence = new List<int>();
                //        maxSequence.AddRange(sequence);
                //        maxSum = 0;
                //    }
                //    else if(sequence.Count == maxSequence.Count && sum > maxSum)
                //    {
                //        maxSequence = new List<int>();
                //        maxSequence.AddRange(sequence);
                //        maxSum = 0;
                //    }

                //    sequence.RemoveAll(x => x > listOfNumbers[i + 1]);
                //    sequence.Add(listOfNumbers[i + 1]);
                //    sum = 0;

                //}
            }
            Console.WriteLine(string.Join(" ", maxSequence));
        }
    }
}
