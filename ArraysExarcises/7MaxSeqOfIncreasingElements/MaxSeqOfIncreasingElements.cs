using System;
using System.Linq;


namespace _6.MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqlElements
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var end = 0;
            var bestEnd = 0;
            var len = 1;
            var maxLen = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] < sequence[i + 1])
                {
                    len++;
                    end = i;
                    if (len > maxLen)
                    {
                        maxLen = len;
                        bestEnd = end;
                    }
                }
                else
                {
                    if (len > maxLen)
                    {
                        maxLen = len;
                        bestEnd = i;
                    }
                    len = 1;
                }

            }
            //Console.WriteLine(maxLen);
            //Console.WriteLine(bestStart);

            for (int i = bestEnd + 1 - maxLen + 1; i <= bestEnd + 1; i++)
            {
                Console.Write("{0} ", sequence[i]);
            }
            Console.WriteLine();


        }
    }
}