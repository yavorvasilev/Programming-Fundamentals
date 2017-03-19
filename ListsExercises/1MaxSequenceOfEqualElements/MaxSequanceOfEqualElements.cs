using System;
using System.Collections.Generic;
using System.Linq;

namespace _1MaxSequenceOfEqualElements
{
    public class MaxSequanceOfEqualElements
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var start = 0;
            var maxLen = 0;
            var len = 0;
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                len = listOfNumbers.Count(x=> x == listOfNumbers[i]);
                if (len > maxLen)
                {
                    maxLen = len;
                    start = i;
                }
                else
                {
                    len = 0;
                }
                
            }
            for (int i = start; i < start + maxLen; i++)
            {
                Console.Write("{0} ",listOfNumbers[i]);
            }
            Console.WriteLine();
            //Console.WriteLine(string.Join(" ", (x=> x >= listOfNumbers[start] && x <= listOfNumbers[start + maxLen]));
            

        }
    }
}
