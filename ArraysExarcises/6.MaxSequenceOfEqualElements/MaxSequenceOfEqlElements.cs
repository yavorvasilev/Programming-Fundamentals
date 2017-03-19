using System;
using System.Linq;


namespace _6.MaxSequenceOfEqualElements
{
    public class MaxSequenceOfEqlElements
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var start = 0;
            var bestStart = 0;
            var len = 1;
            var maxLen = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    len++;
                    start = i;
                    if (len > maxLen)
                    {
                        maxLen = len;
                        bestStart = start;

                    }
                }
                else
                {
                    if (len > maxLen)
                    {
                        maxLen = len;
                        bestStart = i;

                    }
                    len = 1;
                }

            }
            //Console.WriteLine(maxLen);
            //Console.WriteLine(bestStart);

            for (int i = 0; i < maxLen; i++)
            {
                Console.Write("{0} ", sequence[bestStart]);
            }
            Console.WriteLine();

        }
    }
}
